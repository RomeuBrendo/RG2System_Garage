using RG2System_Garage.Domain.Commands.Configuracao;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Configuracao
{
    public partial class frmDadosEmpresa : MetroFramework.Forms.MetroForm
    {
        private IServiceConfiguracaoDadosEmpresa _serviceDadosEmpresa;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid IdEstaSendoEditado;
        public frmDadosEmpresa()
        {
            InitializeComponent();
            ConsultarDepedencias();
            IdEstaSendoEditado = Guid.Empty;
            CarregaTela();
        }

        private void CarregaTela()
        {
            try
            {
                _serviceDadosEmpresa.ClearNotifications();
                
                var response = _serviceDadosEmpresa.ObterDadosEmpresa();

                if (VerificaNotificacoes(_serviceDadosEmpresa))
                {
                    if (response == null)
                        return;

                    IdEstaSendoEditado = response.Id;
                    txtNomeFantasia.Text = response.NomeFantasia;
                    txtRazaoSocial.Text = response.RazaoSocial;
                    txtCelular.Text = response.Celular;
                    txtFixo.Text = response.Fixo;
                    txtEmail.Text = response.Email;
                    txtEndereco.Text = response.Endereco;
                    txtNomeFantasia.Focus();
                }
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_AO_CONSULTAR_DADOS, EnumToast.Erro);
                return;
            }
        }

        void Salvar()
        {
            try
            {
                _serviceDadosEmpresa.ClearNotifications();
                var request = new DadosEmpresaRequest();

                if ((IdEstaSendoEditado != Guid.Empty) && (IdEstaSendoEditado != null))
                    request.Id = IdEstaSendoEditado;

                request.NomeFantasia = txtNomeFantasia.Text;
                txtNomeFantasia.Focus();
                request.RazaoSocial = txtRazaoSocial.Text;
                request.Celular = txtCelular.Text;
                request.Email = txtEmail.Text;
                request.Endereco = txtEndereco.Text;

                _serviceDadosEmpresa.AdicionarAlterar(request);

                if (VerificaNotificacoes(_serviceDadosEmpresa))
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast(MSG.OPERACAO_REALIZADA_COM_SUCESSO, EnumToast.Sucesso);
                    this.Close();
                }
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO, EnumToast.Erro);
                txtNomeFantasia.Focus();
                return;
            }
        }

        void ConsultarDepedencias()
        {
            _serviceDadosEmpresa = (IServiceConfiguracaoDadosEmpresa)Program.ServiceProvider.GetService(typeof(IServiceConfiguracaoDadosEmpresa));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }
        private void frmDadosEmpresa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
                btnSalvar.PerformClick();

            if (e.KeyCode == Keys.Escape)
                btnCancelar.PerformClick();

        }

        private void txtNomeFantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;
        }

        private void txtNomeFantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtRazaoSocial.Focus();
        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCelular.Focus();
        }

        private void txtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFixo.Focus();
        }

        private void txtFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEndereco.Focus();
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNomeFantasia.Focus();
        }
        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (serviceBase.Notifications.Count > 0)
            {
                foreach (var item in serviceBase.Notifications.ToList())
                    toast.ShowToast(item.Message, EnumToast.Erro);

                txtNomeFantasia.Focus();
                
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDadosEmpresa_Load(object sender, EventArgs e)
        {
            this.Refresh();
            txtNomeFantasia.Focus();
        }
    }
}
