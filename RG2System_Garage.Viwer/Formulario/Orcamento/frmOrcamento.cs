using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Enum.Orcamento;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Orcamento
{
    public partial class frmOrcamento : MetroFramework.Forms.MetroForm
    {
        private IServiceOrcamento _serviceOrcamento;
        private IUnitOfWork _unitOfWork;
        private IServiceCliente _serviceCliente;
        private IServiceProduto _serviceProdutoServico;

        public bool CentralizarTela = false;
        Toast toast = new Toast();

        Guid IdClienteSelecionado, IdVeiculoSelecionado = Guid.Empty;

        public frmOrcamento()
        {
            InitializeComponent();
            ConsultarDepedencias();
            AjustaTelaTamanho(0);
            Passo_0("");

        }
        void ConsultarDepedencias()
        {
            _serviceOrcamento = (IServiceOrcamento)Program.ServiceProvider.GetService(typeof(IServiceOrcamento));
            _serviceCliente = (IServiceCliente)Program.ServiceProvider.GetService(typeof(IServiceCliente));
            _serviceProdutoServico = (IServiceProduto)Program.ServiceProvider.GetService(typeof(IServiceProduto));
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

                if (tabControlOrcamento.SelectedIndex == 2)
                {
                    Passo_1(false);
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
            Passo_1(true);

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
        private void Passo_1(bool atualizarGrid) // Selecionar Cliente para criação do Orçamento
        {
            try
            {
                if (atualizarGrid)
                    CarregaGrid(dataGridCliente, "", EnumListar.Cliente);

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

        private void Passo_2()
        {
            Passo_2(true);
        }
        private void Passo_2(bool atualizarGrid)
        {
            try
            {
                if (atualizarGrid)
                    CarregaGrid(dataGridVeículo, EnumListar.Veiculo, IdClienteSelecionado);

                this.Text = "Selecionar Veículo p/ Orçamento";

                lblClienteTitulo.Text = dataGridCliente.SelectedRows[0].Cells[1].Value.ToString();

                tabControlOrcamento.SelectedIndex = 2;

                if (!panelSubMenu.Visible)
                    panelSubMenu.Visible = true;

                this.Refresh();
                dataGridVeículo.Focus();
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_AO_LISTA_X0.ToFormat("Veículos"), EnumToast.Erro);
                return;
            }
        }

        private void Passo_3()
        {
            Passo_3(true);
        }
        private void Passo_3(bool atualizarGrid)
        {
            try
            {
                txtCliente.Text = lblClienteTitulo.Text;
                txtPlaca.Text = dataGridVeículo.SelectedRows[0].Cells[1].Value.ToString();

                if (atualizarGrid)
                {
                    CarregaGrid(dataGridProduto, "", EnumListar.Produto);
                    CarregaGrid(dataGridServico, "", EnumListar.Servico);

                    dataGridServico.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridProduto.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dataGridServico.Focus();
            }
            catch
            { 
                toast.ShowToast(MSG.ERRO_AO_LISTA_X0.ToFormat("Serviços/Produtos"), EnumToast.Erro);
                return;

            }
        }
        private DataGridView CarregaGrid(DataGridView grid, EnumListar acao, Guid id)
        {
            return CarregaGrid(grid, "", acao, id);
        }
        private DataGridView CarregaGrid(DataGridView grid, string pesquisar, EnumListar acao)
        {
            return CarregaGrid(grid, pesquisar, acao, null);
        }
        private DataGridView CarregaGrid(DataGridView grid, string pesquisar, EnumListar acao, Guid? id)
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = null;

            if (acao == EnumListar.Cliente)
                grid.DataSource = _serviceCliente.Listar(pesquisar);
            
            if (acao == EnumListar.Orcamento)
                grid.DataSource = _serviceOrcamento.Listar(pesquisar);
            
            if (acao == EnumListar.Veiculo)
                grid.DataSource = _serviceCliente.ListarVeiculos_byCliente(id.Value);
            
            if (acao == EnumListar.Servico)
                grid.DataSource = _serviceProdutoServico.ListarProdutoOuServico(EnumTipo.Servico);

            if (acao == EnumListar.Produto)
                grid.DataSource = _serviceProdutoServico.ListarProdutoOuServico(EnumTipo.Produto);

            grid.Update();
            grid.Refresh();

            return grid;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Passo_0("");
        }

        private void lblRetornar_Click(object sender, EventArgs e)
        {
            if (tabControlOrcamento.SelectedIndex == 1)
                Passo_0("");
            else if (tabControlOrcamento.SelectedIndex == 2)
                Passo_1(false);
            else if (tabControlOrcamento.SelectedIndex == 3)
            {
                AjustaTelaTamanho(0);
                Passo_2();
            }

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
                SelecionaGrid(dataGridCliente, EnumIcone.ClienteSelecionado);
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridVeículo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Enter))
            {
                SelecionaGrid(dataGridVeículo, EnumIcone.VeiculoSelecionado);
                e.SuppressKeyPress = true;
            }
        }


        private DataGridView SelecionaGrid(DataGridView grid, EnumIcone iconeNovo) //Uso essa função p/ Cliente e Veículos
        {
            try
            {
                var linhaSelecionada = grid.SelectedRows[0].Index;
                var linhaJaSelecionadaAntes = false;

                for (int x = 0; x <= grid.Rows.Count - 1; x++)
                {
                    if (((Bitmap)grid.Rows[x].Cells[0].Value).Flags != Properties.Resources.Branco1.Flags)
                    {
                        grid.Rows[x].Cells[0].Value = Properties.Resources.Branco1;

                        if (grid.Rows[x].Index == linhaSelecionada)
                        {
                            linhaJaSelecionadaAntes = true;
                            IdClienteSelecionado = Guid.Empty;
                            IdVeiculoSelecionado = Guid.Empty;
                        }
                    }
                }

                var icone = Properties.Resources.Branco1;

                if (iconeNovo == EnumIcone.ClienteSelecionado)
                {
                    icone = Properties.Resources.clienteSelecionado;
                    if (!linhaJaSelecionadaAntes)
                    {
                        IdVeiculoSelecionado = Guid.Empty;
                        IdClienteSelecionado = (Guid)grid.Rows[linhaSelecionada].Cells[2].Value;
                    }
                }
                else if (iconeNovo == EnumIcone.VeiculoSelecionado)
                {
                    icone = Properties.Resources.VeiculoSelecionado;
                    if (!linhaJaSelecionadaAntes)
                        IdVeiculoSelecionado = (Guid)grid.Rows[linhaSelecionada].Cells[2].Value;
                }

                if (!linhaJaSelecionadaAntes)
                    grid.Rows[linhaSelecionada].Cells[0].Value = icone;

                return grid;
            }
            catch
            {
                toast.ShowToast(MSG.ERRO_AO_SELECIONAR_X0.ToFormat(iconeNovo), EnumToast.Erro);
                return null;
            }
        }

        private void dataGridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridCliente.SelectedRows[0].Index)
                SelecionaGrid(dataGridCliente, EnumIcone.ClienteSelecionado);
        }

        private void dataGridVeículo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaGrid(dataGridVeículo, EnumIcone.VeiculoSelecionado);
        }

        private void lblProximo_Click(object sender, EventArgs e)
        {
            if (tabControlOrcamento.SelectedIndex == 1)
            {
                if ((IdClienteSelecionado != Guid.Empty) && (IdClienteSelecionado != null))
                {
                    if (IdVeiculoSelecionado == Guid.Empty)
                        Passo_2();
                    else
                        Passo_2(false); //Atualiza grid
                }
                else
                {
                    toast.ShowToast(MSG.E_NECESSARIO_SELECIONAR_UM_X0_PARA_PROSSEGUIR.ToFormat("Cliente"), EnumToast.Informacao);
                    dataGridCliente.Focus();
                }
            }
            else if (tabControlOrcamento.SelectedIndex == 2)
            {
                this.Visible = false;
                AjustaTelaTamanho(3);
                tabControlOrcamento.SelectedIndex = 3;
                Passo_3();
                Thread.Sleep(150);
                this.Refresh();
                this.Visible = true;
            }
        }

        void AjustaTelaTamanho(int passo)
        {
            if (passo != 3)
            {
                this.Size = new Size(842, 691);
                tabControlOrcamento.Size = new Size(807, 558);
            }
            else
            {
                this.Size = new Size(1105, 757);
                tabControlOrcamento.Size = new Size(1070, 624);
            }

        }

    }
}
