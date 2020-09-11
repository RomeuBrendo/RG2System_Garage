using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using System;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Veiculo
{
    public partial class frmVeiculo :  MetroFramework.Forms.MetroForm
    {
        private IServiceVeiculo _serviceVeiculo;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        public frmVeiculo()
        {
            InitializeComponent();
            TabControlVeiculo.SelectedIndex = 0;
            txtPesquisar.Focus();
            ConsultarDepedencias();
            
        }

        void ConsultarDepedencias()
        {
            _serviceVeiculo = (IServiceVeiculo)Program.ServiceProvider.GetService(typeof(IServiceVeiculo));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }

        private void frmVeiculo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (TabControlVeiculo.SelectedIndex == 0)
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

            if (TabControlVeiculo.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Escape)
                    btnCancelarNovo.PerformClick();

                if (e.KeyCode == Keys.F4)
                    btnSalvar.PerformClick();
            }

        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {         
            TabControlVeiculo.SelectedIndex = 1;
            txtModelo.Focus();
        }

        private void btnAlterar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Alterar");
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Excluir");
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmVeiculo_Load(object sender, System.EventArgs e)
        {
            if (TabControlVeiculo.SelectedIndex == 0)
              txtPesquisar.Focus();

            if (TabControlVeiculo.SelectedIndex == 1)
                txtModelo.Focus();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPlaca.Focus();
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dateTimeAno.Focus();
        }

        private void txtAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtModelo.Focus();
        }

        private void btnCancelarNovo_Click(object sender, System.EventArgs e)
        {
            TabControlVeiculo.SelectedIndex = 0;
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            toast.ShowToast("Tesste", EnumToast.Erro);        
        }

        public void LimparCampos()
        {
            foreach (Control item in this.panelCadastroVeiculo.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }

            dateTimeAno.Value = DateTime.Now;
        }

        private void dateTimeAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesabilitaEvento(e);
        }

        private void dateTimeAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtModelo.Focus();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesabilitaEvento(e);
        }

        void DesabilitaEvento(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                e.Handled = true;
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesabilitaEvento(e);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesabilitaEvento(e);
        }
    }
}
