using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using System;
using System.Linq;
using System.Windows.Forms;
using prmToolkit.NotificationPattern;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using RG2System_Garage.Domain.Commands.Veiculo;

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
            carregarTelaSelecao();

        }

        void carregarTelaSelecao()
        {
           dataGridVeiculo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVeiculo.DataSource = null;
            var veiculos = _serviceVeiculo.ListarVeiculo("");

            if (VerificaNotificacoes(_serviceVeiculo) && (veiculos != null))
            {
                dataGridVeiculo.DataSource = veiculos.OrderBy(x => x.Modelo).ToList();
                dataGridVeiculo.Update();
                dataGridVeiculo.Refresh();
            }

        }

        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (_serviceVeiculo.Notifications.Count > 0)
            {
                foreach (var item in _serviceVeiculo.Notifications.ToList())
                {
                    toast.ShowToast(item.Message, EnumToast.Erro);
                }
                txtModelo.Focus();
                return false;
            }
            return true;
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
            var veiculo = new VeiculoRequest();

            veiculo.Modelo = txtModelo.Text;
            veiculo.Placa = txtPlaca.Text;
            veiculo.Ano = dateTimeAno.Value;

            _serviceVeiculo.AdicionarOuAlterar(veiculo);

            if (VerificaNotificacoes(_serviceVeiculo))
            {
                try
                {
                    _unitOfWork.SaveChanges();
                    toast.ShowToast("Veículo Cadastrado com Sucesso", EnumToast.Sucesso);
                    TabControlVeiculo.SelectedIndex = 0;
                    carregarTelaSelecao();
                    txtPesquisar.Focus();
                }
                catch
                {
                    toast.ShowToast("Erro ao realizar Commite", EnumToast.Erro);
                }

            }

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
