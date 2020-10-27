using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
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

                throw;
            }
        }
        private void Passo_1() // Selecionar Cliente para criação do Orçamento
        {
            try
            {
                dataGridCliente.AutoGenerateColumns = false;
                dataGridCliente.DataSource = null;
                dataGridCliente.DataSource = _serviceCliente.Listar("");
                dataGridCliente.Columns[1].ReadOnly = true;

                dataGridCliente.Update();
                dataGridCliente.Refresh();

                this.Text = "Selecionar Cliente p/ Orçamento";
                tabControlOrcamento.SelectedIndex = 1;

                if (!panelSubMenu.Visible)
                    panelSubMenu.Visible = true;

                this.Refresh();
                dataGridCliente.Focus();
            }
            catch
            {

                throw;
            }

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

        private void dataGridCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                if (IndexLinhaSelecionada == -2)
                    IndexLinhaSelecionada = e.RowIndex;
                else if (IndexLinhaSelecionada != e.RowIndex)
                {
                    dataGridCliente.Rows[IndexLinhaSelecionada].Cells[0].Value = false;
                    IndexLinhaSelecionada = IndexLinhaSelecionada = e.RowIndex;
                }
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridCliente.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                try
                {
                    var valor = Convert.ToBoolean(dataGridCliente.Rows[dataGridCliente.SelectedRows[0].Index].Cells[0].Value);
                    if (valor)
                        valor = false;
                    else
                    {
                        valor = true;
                        //dataGridCliente.Rows[dataGridCliente.SelectedRows[0].Index].Cells[1].Value = Properties.
                    }

                    dataGridCliente.Rows[dataGridCliente.SelectedRows[0].Index].Cells[0].Value = valor;
                }
                catch
                {

                    throw;
                }
            }
        }
    }
}
