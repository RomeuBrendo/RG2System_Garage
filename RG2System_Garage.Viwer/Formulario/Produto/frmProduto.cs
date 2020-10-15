using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Produto;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Produto
{
    public partial class frmProduto : MetroFramework.Forms.MetroForm
    {
        private IServiceProduto _serviceProduto;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid IdEstaSendoEditado;
        public frmProduto()
        {
            InitializeComponent();
            tabControlProduto.SelectedIndex = 0;
            ConsultarDepedencias();
            IdEstaSendoEditado = Guid.Empty;
            CarregaGridProduto("");
            AplicarEventos(txtPrecoCusto);
            AplicarEventos(txtPrecoVenda);
        }
        void ConsultarDepedencias()
        {
            _serviceProduto = (IServiceProduto)Program.ServiceProvider.GetService(typeof(IServiceProduto));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }
        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            this.Text = "Novo Produto";
            tabControlProduto.SelectedIndex = 1;
            this.Height = 340;
            this.Refresh();
            txtDescricao.Focus();
        }

        private void btnAlterar_Click(object sender, System.EventArgs e)
        {
            Alterar();
        }

        private void Alterar()
        {
            try
            {
                _serviceProduto.ClearNotifications();
                this.Text = "Alterar Produto";
                var idProdutoSelecionado = IdProdutoSelecionado();
                var produto = _serviceProduto.ObterProdutoId(idProdutoSelecionado);

                if (VerificaNotificacoes(_serviceProduto))
                {
                    IdEstaSendoEditado = produto.Id;
                    txtDescricao.Text = produto.Descricao;
                    txtEstoqueAtual.Text = produto.Estoque.ToString();
                    txtPrecoCusto.Text = double.Parse(produto.PrecoCusto.ToString()).ToString("C2");
                    txtPrecoVenda.Text = double.Parse(produto.PrecoVenda.ToString()).ToString("C2");
                    
                    tabControlProduto.SelectedIndex = 1;
                    this.Height = 340;
                    
                    txtDescricao.Focus();
                }

            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
            }
        }

        private Guid IdProdutoSelecionado()
        {
            try
            {
                var produtoSelecionado = dataGridProduto.SelectedRows[0].DataBoundItem as ProdutoResponse;
                return produtoSelecionado.Id;
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                return Guid.Empty;
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("No momento não é possível realizar exclusão. Estamos criando ferramenta para inativar produto, em breve estará dísponivel.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            if (tabControlProduto.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Insert)
                    btnNovo.PerformClick();

                if (e.KeyCode == Keys.F5)
                    btnAlterar.PerformClick();

                if (e.KeyCode == Keys.Delete)
                    btnExcluir.PerformClick();

                if (e.KeyCode == Keys.Escape)
                    btnSair.PerformClick();
            }

            if (tabControlProduto.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Escape)
                    btnCancelarNovo.PerformClick();

                if (e.KeyCode == Keys.F4)
                    btnSalvar.PerformClick();
            }
        }

        private void btnCancelarNovo_Click(object sender, System.EventArgs e)
        {
            tabControlProduto.SelectedIndex = 0;
            LimparCampos();
        }

        public void LimparCampos()
        {
            foreach (Control item in this.panelCadastroProduto.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }

            this.Text = "Selecionar Produto";
            this.Height = 505;
            this.Refresh();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            var request = new AdionarAlterarProdutoRequest();
           
            var operacao = "inserido";
            if (IdEstaSendoEditado != Guid.Empty)
            {
                request.Id = IdEstaSendoEditado;
                operacao = "alterado";
            }
            
            request.Descricao = txtDescricao.Text;
            request.PrecoCusto = txtPrecoCusto.Text.Replace("R$", "").Trim(); 
            request.PrecoVenda = txtPrecoVenda.Text.Replace("R$", "").Trim();
            request.Estoque = txtEstoqueAtual.Text;

            try
            {
                _serviceProduto.ClearNotifications();
                _serviceProduto.AdionarAlterar(request);

                if (VerificaNotificacoes(_serviceProduto))
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast(MSG.CADASTRO_X0_COM_SUCESSO.ToFormat(operacao), EnumToast.Sucesso);
                    tabControlProduto.SelectedIndex = 0;
                    CarregaGridProduto("");
                    LimparCampos();
                    dataGridProduto.Focus();
                }
                else
                    txtDescricao.Focus();

            }
            catch 
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                txtDescricao.Focus();
            }
        }

        void CarregaGridProduto(string nome)
        {

            dataGridProduto.DataSource = null;
            dataGridProduto.AutoGenerateColumns = false;
            dataGridProduto.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduto.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridProduto.Columns[1].DefaultCellStyle.Format = "N2";
            var produtos = _serviceProduto.Listar(nome);

            if (produtos == null)
                return;

            if (VerificaNotificacoes(_serviceProduto))
            {
                dataGridProduto.DataSource = produtos.OrderBy(x => x.Descricao).ToList();
                dataGridProduto.Update();
                dataGridProduto.Refresh();
            }

        }
        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEstoqueAtual.Focus();
        }

        private void txtEstoqueAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoCusto.Focus();
        }

        private void txtPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoVenda.Focus();
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDescricao.Focus();
        }

        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (serviceBase.Notifications.Count > 0)
            {
                foreach (var item in serviceBase.Notifications.ToList())
                    toast.ShowToast(item.Message, EnumToast.Erro);
                
                if (tabControlProduto.SelectedIndex == 0)
                    txtPesquisar.Focus();
                else
                    txtDescricao.Focus();

                return false;
            }
            return true;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            try
            {              
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch
            {
                
                txt.Text = "";
            }

        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void dataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alterar();
        }

        private void dataGridProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Alterar();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Length > 0)
                CarregaGridProduto(txtPesquisar.Text);
            else
                CarregaGridProduto("");
        }
    }
}
