using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Cliente;
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

namespace RG2System_Garage.Viwer.Formulario.Cliente
{
    public partial class frmCliente : MetroFramework.Forms.MetroForm
    {
        private IServiceCliente _serviceCliente;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid IdEstaSendoEditado;

        public frmCliente()
        {
            InitializeComponent();
            ConsultarDepedencias();
            dataGridCliente.AutoGenerateColumns = false;
            dataGridCliente.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CarregaGridCliente("");
            IdEstaSendoEditado = Guid.Empty;
        }

        void CarregaGridCliente(string nome)
        {

            dataGridCliente.DataSource = null;

            var veiculos = _serviceCliente.Listar(nome);

            if (VerificaNotificacoes(_serviceCliente))
            {
                dataGridCliente.DataSource = veiculos.OrderBy(x => x.Nome).ToList();
                dataGridCliente.Update();
                dataGridCliente.Refresh();
            }

        }

        private ClienteResponse ClienteSelecionado()
        {
            try
            {
                return dataGridCliente.SelectedRows[0].DataBoundItem as ClienteResponse;
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                return null;
            }
        }

        void ConsultarDepedencias()
        {
            _serviceCliente = (IServiceCliente)Program.ServiceProvider.GetService(typeof(IServiceCliente));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }
        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (serviceBase.Notifications.Count > 0)
            {
                foreach (var item in serviceBase.Notifications.ToList())
                {
                    toast.ShowToast(item.Message, EnumToast.Erro);
                }
                if (tabControlCliente.SelectedIndex == 0)
                    txtPesquisar.Focus();
                else
                    txtNome.Focus();

                return false;
            }
            return true;
        }

        private void frmCliente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (tabControlCliente.SelectedIndex == 0)
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

            if (tabControlCliente.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Escape)
                    btnCancelarNovo.PerformClick();

                if (e.KeyCode == Keys.F4)
                    btnSalvar.PerformClick();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
            this.Text = "Novo Cliente";
            this.Refresh();
            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCliente();
        }

        void AlterarCliente()
        {
            try
            {
                this.Text = "Alterar Cliente";
                var clienteSelecionado = ClienteSelecionado();
                var request = _serviceCliente.ObterClienteId(clienteSelecionado.Id.Value);

                if (_serviceCliente == null)
                {
                    toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                    txtNome.Focus();
                    return;
                }

                if (VerificaNotificacoes(_serviceCliente))
                {
                    tabControlCliente.SelectedIndex = 1;
                    IdEstaSendoEditado = request.Id.Value;
                    txtNome.Text = request.Nome;
                    txtCPFCPNJ.Text = request.CPFCNPJ;
                    txtTelefone1.Text = request.Telefone1;
                    txtTelefone2.Text = request.Telefone2;
                    this.Refresh();
                    txtNome.Focus();
                };
            }
            catch
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteselecionado = ClienteSelecionado();

                if (clienteselecionado == null)
                    return;

                DialogResult dialogResult = MessageBox.Show("Deseja confirmar exclusão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.No)
                    return;

                _serviceCliente.Deletar(clienteselecionado.Id.Value);

                if (VerificaNotificacoes(_serviceCliente))
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast(MSG.OPERACAO_REALIZADA_COM_SUCESSO, EnumToast.Sucesso);
                    tabControlCliente.SelectedIndex = 0;
                    CarregaGridCliente("");
                    txtPesquisar.Focus();
                }
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                txtPesquisar.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarNovo_Click(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 0;
            LimparCampos();
            this.Refresh();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCPFCPNJ.Focus();
        }

        private void txtCPFCPNJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTelefone1.Focus();
        }

        private void txtTelefone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTelefone2.Focus();
        }

        private void txtTelefone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridVeiculo.Focus();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (tabControlCliente.SelectedIndex == 0)
                txtPesquisar.Focus();

            if (tabControlCliente.SelectedIndex == 1)
                txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var request = new ClienteRequest();

            var operacao = "inserido";

            if (IdEstaSendoEditado != Guid.Empty)
            {
                request.Id = IdEstaSendoEditado;
                operacao = "alterado";
            }

            request.Nome = txtNome.Text;
            request.CPFCNPJ = txtCPFCPNJ.Text;
            request.Telefone1 = txtTelefone1.Text;
            request.Telefone2 = txtTelefone2.Text;

            try
            {
                _serviceCliente.AdicionarAlterar(request);

                if (VerificaNotificacoes(_serviceCliente))
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast(MSG.CADASTRO_X0_COM_SUCESSO.ToFormat(operacao), EnumToast.Sucesso);
                    tabControlCliente.SelectedIndex = 0;
                    LimparCampos();
                    CarregaGridCliente("");
                    txtPesquisar.Focus();
                }
                else
                    txtNome.Focus();
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                txtNome.Focus();
                return;
            }
        }
        public void LimparCampos()
        {
            foreach (Control item in this.panelCadastroVeiculo.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }

            IdEstaSendoEditado = Guid.Empty;
            this.Text = "Selecionar Cliente";
            this.Refresh();
        }

        private void dataGridCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAlterar.PerformClick();
        }
    }
}
