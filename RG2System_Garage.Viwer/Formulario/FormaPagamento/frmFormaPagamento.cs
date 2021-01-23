using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.FormaPagamento
{
    public partial class frmFormaPagamento : MetroFramework.Forms.MetroForm
    {
        private IServiceFormaPagamento _serviceFormaPagamento;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid _idEstaSendoEditado;
        public frmFormaPagamento()
        {
            InitializeComponent();
            ConsultarDepedencias();
            _idEstaSendoEditado = Guid.Empty;
            TabControlFormaPagamento.SelectedIndex = 0;
            CarregaGridProduto();
        }

        void ConsultarDepedencias()
        {
            _serviceFormaPagamento = (IServiceFormaPagamento)Program.ServiceProvider.GetService(typeof(IServiceFormaPagamento));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }

        void CarregaGridProduto()
        {
            dataGridFormaPagamento.DataSource = null;
            dataGridFormaPagamento.AutoGenerateColumns = false;
            dataGridFormaPagamento.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var response = _serviceFormaPagamento.Listar("");

            if (response == null)
                return;

            if (VerificaNotificacoes(_serviceFormaPagamento))
            {
                dataGridFormaPagamento.DataSource = response.OrderBy(x => x.Descricao).ToList();
                dataGridFormaPagamento.Update();
                dataGridFormaPagamento.Refresh();
            }
        }

        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (serviceBase.Notifications.Count > 0)
            {
                foreach (var item in serviceBase.Notifications.ToList())
                    toast.ShowToast(item.Message, EnumToast.Erro);

                if (TabControlFormaPagamento.SelectedIndex == 0)
                    TabControlFormaPagamento.Focus();
                else
                    txtDescricao.Focus();

                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            TabControlFormaPagamento.SelectedIndex = 1;
            cmbTipo.SelectedIndex = 0;
            txtDescricao.Focus();
        }

        public void Salvar()
        {
            try
            {
                var request = new FormaPagamentoRequest();

                var operacao = "realizado";
                if (_idEstaSendoEditado != Guid.Empty)
                    operacao = "alterado";

                request.Id = _idEstaSendoEditado;
                request.Descricao = txtDescricao.Text;
                request.Tipo = (EnumFormaPgtTipo)cmbTipo.SelectedIndex;
                request.PrazoRecebimento = Convert.ToInt32(txtPrazoRecebimento.Text);
                request.QuantidadeParcela = Convert.ToInt32(txtParcelas.Text);

                _serviceFormaPagamento.AdicionarAlterar(request);

                if (VerificaNotificacoes(_serviceFormaPagamento))
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast(MSG.CADASTRO_X0_COM_SUCESSO.ToFormat(operacao), EnumToast.Sucesso);
                    TabControlFormaPagamento.SelectedIndex = 0;
                    LimparCampos();
                    CarregaGridProduto();
                    dataGridFormaPagamento.Focus();
                }

            }
            catch (Exception ex)
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var formaPagamentoSelecionada = FormaPagamentoSelecionada();

            if (formaPagamentoSelecionada == null)
                return;

            DialogResult dialogResult = MessageBox.Show("Deseja confirmar exclusão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.No)
                return;

            try
            {
                _serviceFormaPagamento.Excluir(formaPagamentoSelecionada.Id.Value);

                if (VerificaNotificacoes(_serviceFormaPagamento))
                {
                    _unitOfWork.SaveChanges();
                    CarregaGridProduto();
                    toast.ShowToast("Exclusão realizada com sucesso!", EnumToast.Sucesso);
                    this.dataGridFormaPagamento.Focus();
                }

            }
            catch
            {
                toast.ShowToast("Erro ao tentar Deletar. Tente Novamente!", EnumToast.Erro);
            }
        }

        private FormaPagamentoResponse FormaPagamentoSelecionada()
        {
            try
            {
                return dataGridFormaPagamento.SelectedRows[0].DataBoundItem as FormaPagamentoResponse;
            }
            catch
            {
                toast.ShowToast("Nenhuma Forma de Pagamento foi selecionado.", EnumToast.Erro);
                return null;
            }
        }

        public void LimparCampos()
        {
            foreach (Control item in this.panelCadastroFormapagamento.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
            
            _idEstaSendoEditado = Guid.Empty;
            this.Text = "Selecionar Forma Pagamento";
            this.Refresh();
        }

        void Cancelar()
        {
            LimparCampos();
            TabControlFormaPagamento.SelectedIndex = 0;
            dataGridFormaPagamento.Focus();
        }
        private void btnCancelarNovo_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var formaPagamentoSelecionada = FormaPagamentoSelecionada();

                if (formaPagamentoSelecionada == null)
                    return;

                var response = _serviceFormaPagamento.ObterPorId(formaPagamentoSelecionada.Id.Value);

                _idEstaSendoEditado = response.Id.Value;
                txtDescricao.Text = response.Descricao;
                cmbTipo.SelectedIndex = (int)response.Tipo;
                txtPrazoRecebimento.Text = Convert.ToString(response.PrazoRecebimento);
                txtParcelas.Text = Convert.ToString(response.QuantidadeParcela);

                TabControlFormaPagamento.SelectedIndex = 1;
                this.Text = "Alteração Forma Pagamento";
                txtDescricao.Focus();
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                return;
            }
        }

        private void frmFormaPagamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (TabControlFormaPagamento.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Insert)
                    btnNovo.PerformClick();

                if (e.KeyCode == Keys.F5)
                    btnAlterar.PerformClick();

                if (e.KeyCode == Keys.Escape)
                    this.Close();

                return;
            }
            if (TabControlFormaPagamento.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.F4)
                    btnSalvar.PerformClick();

                if (e.KeyCode == Keys.Escape)
                {
                    Cancelar();
                    return;
                }

                if (e.KeyCode == Keys.Enter)
                      SendKeys.Send("{TAB}");
            }


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                txtParcelas.Enabled = false;
                txtParcelas.Text = "0";
                txtPrazoRecebimento.Enabled = false;
                txtPrazoRecebimento.Text = "0";
            }
            else if (cmbTipo.SelectedIndex == 1) //Debito
            {
                txtPrazoRecebimento.Enabled = true;
                txtParcelas.Enabled = false;
                txtParcelas.Text = "0";
            }
            else
            {
                txtParcelas.Enabled = true;
                txtPrazoRecebimento.Enabled = true;
            }
        }

        private void txtPrazoRecebimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) //Aceitar somente números no campo.
                e.Handled = true;
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;

        }

        //Posteriormente será necessario passar essa função pra dentro do serviço, assim ficando generica
        public bool PesquisaDataGrid(DataGridView grid, string descricao, int index)
        {
            try
            {
                if (descricao.Trim() != "")
                    foreach (DataGridViewRow item in grid.Rows)
                    {
                        if (item.Cells[index].Value.ToString().StartsWith(descricao))
                        {
                            grid.Focus();
                            item.Cells[index].Selected = true;

                            return true;
                        }
                    }
                toast.ShowToast("Decrição não localizada", EnumToast.Informacao);
                this.Focus();
                return false;
            }
            catch
            {
                toast.ShowToast("Erro ao popular grid", EnumToast.Erro);
                return false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if ((txtPesquisar.Text.Length) > 2)
            {
                PesquisaDataGrid(dataGridFormaPagamento, txtPesquisar.Text, 0);
                txtPesquisar.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormaPagamento_Load(object sender, EventArgs e)
        {
            if (TabControlFormaPagamento.SelectedIndex == 0)
                dataGridFormaPagamento.Focus();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;
        }

        private void cmbTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
                e.SuppressKeyPress = true;
        }
    }
}
