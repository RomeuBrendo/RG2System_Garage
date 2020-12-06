using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Enum.Orcamento;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        List<OrcamentoItensRequest> _itens = new List<OrcamentoItensRequest>();

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
                this.Visible = false;
                this.Text = "Selecione Produtos e Serviços";
                AjustaTelaTamanho(3);
                txtCliente.Text = lblClienteTitulo.Text;
                txtPlaca.Text = dataGridVeículo.SelectedRows[0].Cells[1].Value.ToString();

                if (atualizarGrid)
                {
                    CarregaGrid(dataGridProduto, "", EnumListar.Produto);
                    CarregaGrid(dataGridServico, "", EnumListar.Servico);

                    dataGridServico.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridProduto.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                tabControlOrcamento.SelectedIndex = 3;

                Thread.Sleep(150);
                this.Refresh();
                this.Visible = true;

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
                Passo_2(false);
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


        private DataGridView SelecionaGrid(DataGridView grid, EnumIcone iconeNovo) 
        {
            try
            {
                var linhaSelecionada = grid.SelectedRows[0].Index;
                var linhaJaSelecionadaAntes = false;

                for (int x = 0; x <= grid.Rows.Count - 1; x++)
                {
                    if (((Bitmap)grid.Rows[x].Cells[0].Value).Flags != Properties.Resources.Branco1.Flags)
                    {
                        if ((iconeNovo != EnumIcone.ProdutoSelecionado) && (iconeNovo != EnumIcone.ServicoSelecionado)) //Produto ou serviço pode possuir varios itens
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

                else if (EprodutoOUservico(iconeNovo))
                {
                    if (!linhaJaSelecionadaAntes)
                        icone = Properties.Resources.ProdutoServicoSelecionado;

                    if (iconeNovo == EnumIcone.ProdutoSelecionado)
                        CalculaTotaisProdutoServico(grid, EnumTipo.Produto, !linhaJaSelecionadaAntes, linhaSelecionada);
                    else
                        CalculaTotaisProdutoServico(grid, EnumTipo.Servico, !linhaJaSelecionadaAntes, linhaSelecionada);

                    if (linhaJaSelecionadaAntes)
                        linhaJaSelecionadaAntes = false; //Apenas para colocar branco na linha já selecionada, porque o mesmo não é feito dentro do for acima
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

        private void CalculaTotaisProdutoServico(DataGridView grid, EnumTipo tipo, Boolean inclusao, int linhaSelecionada)
        {
            try
            {
                var Iprecovenda = 3;
                if (tipo == EnumTipo.Produto) //Verifica em qual coluna está preço de venda
                    Iprecovenda = 4;

                var item = new OrcamentoItensRequest();
               
                if (!inclusao)
                    _itens.RemoveAll(x => x.ProdutoServicoId == (Guid)grid.Rows[linhaSelecionada].Cells[1].Value);
                else
                {
                    item.Tipo = tipo;
                    item.ProdutoServicoId = (Guid)grid.Rows[linhaSelecionada].Cells[1].Value;
                    item.PrecoVenda = Convert.ToDecimal(grid.Rows[linhaSelecionada].Cells[Iprecovenda].Value);
                    
                    if (tipo == EnumTipo.Produto)
                        item.Quantidade = (int)grid.Rows[linhaSelecionada].Cells[3].Value;

                    _itens.Add(item);
                }

                if (tipo == EnumTipo.Servico)
                {
                    txtTotalServico.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Servico).Sum(x => x.PrecoVenda).ToString());
                    textQuantidadeServico.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Servico).Select(x => x.ProdutoServicoId).Count());
                }
                else
                {
                    txtTotalProdutos.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Produto).Sum(x => x.Quantidade * x.PrecoVenda).ToString());
                    textQuantidadeProduto.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Produto).Select(x => x.ProdutoServicoId).Count());
                }

            }
            catch
            {
                return;
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
                Passo_3();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                SelecionaGrid(dataGridServico, EnumIcone.ServicoSelecionado);
        }

        private void dataGridServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaGrid(dataGridServico, EnumIcone.ServicoSelecionado);
        }

        private void txtTotalServico_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        void CalculaTotal()
        {
            txtTotal.Text = Convert.ToString((Convert.ToDecimal(txtTotalProdutos.Text) + Convert.ToDecimal(txtTotalServico.Text) + Convert.ToDecimal(txtAcrescimo.Text)) - Convert.ToDecimal(txtDesconto.Text));
        }

        private void dataGridProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                SelecionaGrid(dataGridProduto, EnumIcone.ProdutoSelecionado);
        }

        private void txtTotalProdutos_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
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
                this.Size = new Size(1105, 809);
                tabControlOrcamento.Size = new Size(1070, 680);
            }

        }

        private bool EprodutoOUservico(EnumIcone icone)
        {
            return ((icone == EnumIcone.ProdutoSelecionado) || (icone == EnumIcone.ServicoSelecionado));
        }

    }
}
