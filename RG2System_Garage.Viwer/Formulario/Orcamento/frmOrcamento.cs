using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Orcamento
{
    public partial class frmOrcamento : MetroFramework.Forms.MetroForm
    {
        private IServiceOrcamento _serviceOrcamento;
        private IUnitOfWork _unitOfWork;
        private IServiceCliente _serviceCliente;
        Toast toast = new Toast();
        Guid IdEstaSendoEditado = Guid.Empty;
        int IndexLinhaSelecionada = -2; //uso para mater somente um checkBox selecionado
        public frmOrcamento()
        {
            InitializeComponent();
            ConsultarDepedencias();
            Passo_0("");
            
        }
        void ConsultarDepedencias()
        {
            _serviceOrcamento = (IServiceOrcamento)Program.ServiceProvider.GetService(typeof(IServiceOrcamento));
            _serviceCliente = (IServiceCliente)Program.ServiceProvider.GetService(typeof(IServiceCliente));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }
        private void frmOrcamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (tabControlOrcamento.SelectedIndex == 0)
                    this.Close();

                if (tabControlOrcamento.SelectedIndex == 1)
                {
                    Passo_0("");
                    return;
                }
            }

            if (e.KeyCode == Keys.Insert)
            {
                if (tabControlOrcamento.SelectedIndex == 0)
                    btnNovo.PerformClick();

                return;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Passo_1();
            
        }
        public void LimparCampos(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }

            this.Refresh();
        }

        private void Passo_0(string cliente) //Selecionar Orçamento
        {
            try
            {
                this.Text = "Selecionar Orçamento";
                dataGridOrcamento.AutoGenerateColumns = false;
                dataGridOrcamento.DataSource = null;
                dataGridOrcamento.DataSource = _serviceOrcamento.Listar(cliente);
                
                if (tabControlOrcamento.SelectedIndex != 0)
                {
                    LimparCampos(panelCliente);
                    tabControlOrcamento.SelectedIndex = 0;
                  
                    if (panelSubMenu.Visible)
                        panelSubMenu.Visible = false;

                    dataGridOrcamento.Focus();
                }

                this.Refresh();
                                    
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_AO_LISTA_X0.ToFormat("Orcamento"), EnumToast.Erro);
                return;
            }
        }
        private void Passo_1() // Selecionar Cliente para criação do Orçamento
        {
            try
            {

                CarregarGridCliente("");
                this.Text = "Selecionar Cliente p/ Orçamento";
                tabControlOrcamento.SelectedIndex = 1;

                if (!panelSubMenu.Visible)
                    panelSubMenu.Visible = true;

                this.Refresh();
                dataGridCliente.Focus();
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_AO_LISTA_X0.ToFormat("Clientes"), EnumToast.Erro);
                return;
            }

        }

        private void CarregarGridCliente(string nome)
        {
            dataGridCliente.AutoGenerateColumns = false;
            dataGridCliente.DataSource = null;

            dataGridCliente.DataSource = _serviceCliente.Listar(nome);
            dataGridCliente.Columns[1].ReadOnly = true;

            dataGridCliente.Update();
            dataGridCliente.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Passo_0("");
        }

        private void lblRetornar_Click(object sender, EventArgs e)
        {
            if (tabControlOrcamento.SelectedIndex == 1)
                Passo_0("");

        }

        private void frmOrcamento_Shown(object sender, EventArgs e)
        {
            dataGridOrcamento.Focus();
        }

        //private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dataGridCliente.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //}

        private void dataGridCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Enter))
            {
                SelecionaGridCliente();
                e.SuppressKeyPress = true;
            }
        }

        private void SelecionaGridCliente()
        {
            try
            { 

                var indexNovoSelecionado = dataGridCliente.SelectedRows[0].Index;
                
                if (indexNovoSelecionado < 0)
                        return;

                dataGridCliente.Rows[indexNovoSelecionado].Cells[0].Value = Properties.Resources.clienteSelecionado;

                if ((IndexLinhaSelecionada > -1) && (indexNovoSelecionado != IndexLinhaSelecionada))
                    dataGridCliente.Rows[IndexLinhaSelecionada].Cells[0].Value = Properties.Resources.Branco1;

                IndexLinhaSelecionada = indexNovoSelecionado;

            }
            catch
            {
                MSG.ERRO_AO_SELECIONAR_X0.ToFormat("Cliente");
                return;
            }
        }

        private void dataGridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex == dataGridCliente.SelectedRows[0].Index)
                SelecionaGridCliente();
        }

        private void textPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            //Preciso verificar melhor quando houver um cliente já selecionado
            //if (textPesquisaCliente.Text.Length > 0)
            //    CarregarGridCliente(textPesquisaCliente.Text);
            //else
            //    CarregarGridCliente("");
        }
    }
}
