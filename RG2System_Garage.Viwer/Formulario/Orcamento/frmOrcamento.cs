using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Enum.Orcamento;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Interfaces.Services.Base;
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

        Guid _IdClienteSelecionado, _IdVeiculoSelecionado = Guid.Empty;

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

        bool VerificaNotificacoes(IServiceBase serviceBase)
        {
            if (serviceBase.Notifications.Count > 0)
            {
                foreach (var item in serviceBase.Notifications.ToList())
                    toast.ShowToast(item.Message, EnumToast.Erro);

                txtPesquisarProduto.Focus();

                return false;
            }
            return true;
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

            if (e.KeyCode == Keys.F4)            
                if ((tabControlOrcamento.SelectedIndex != 0) && (tabControlOrcamento.SelectedIndex != 3))
                    ProximoPasso();           

            if (e.KeyCode == Keys.Insert)
            {
                if (tabControlOrcamento.SelectedIndex == 0)
                    btnNovo.PerformClick();

                return;
            }

            if (e.KeyCode == Keys.Delete)
                if (tabControlOrcamento.SelectedIndex == 0)
                    btnExcluir.PerformClick();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Passo_1(true);

        }
        public void LimparCampos(Panel panel)
        {
            try
            {
                foreach (Control item in panel.Controls)
                {
                    if (item is TextBox)
                        ((TextBox)item).Clear();
                }

                this.Refresh();
            }
            catch
            {
                //toast.ShowToast("Erro ao limpar campos. Detalhes: " + ex, EnumToast.Erro);
                return;
            }

        }

        private void Passo_0(string cliente) //Selecionar Orçamento
        {
            try
            {
                this.Text = "Selecionar Orçamento";
                dataGridOrcamento.AutoGenerateColumns = false;
                dataGridOrcamento.DataSource = null;
                
                _IdClienteSelecionado = Guid.Empty;
                _IdVeiculoSelecionado = Guid.Empty;

                dataGridOrcamento.DataSource = _serviceOrcamento.Listar(cliente);

                dataGridOrcamento.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridOrcamento.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridOrcamento.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (tabControlOrcamento.SelectedIndex != 0)
                {
                    if (tabControlOrcamento.SelectedIndex == 1)
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
                lblFinalizar.Visible = false;
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
                    CarregaGrid(dataGridVeículo, EnumListar.Veiculo, _IdClienteSelecionado);

                this.Text = "Selecionar Veículo p/ Orçamento";

                lblClienteTitulo.Text = dataGridCliente.SelectedRows[0].Cells[1].Value.ToString();
                lblFinalizar.Visible = false;

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
                lblFinalizar.Visible = true;
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
            LimpaPasso3Orcamento();
            Passo_0("");
            AjustaTelaTamanho(0);
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

                            if (!EprodutoOUservico(iconeNovo))
                            {
                                _IdClienteSelecionado = Guid.Empty;
                                _IdVeiculoSelecionado = Guid.Empty;
                            }
 
                        }
                    }
                }

                var icone = Properties.Resources.Branco1;

                if (iconeNovo == EnumIcone.ClienteSelecionado)
                {
                    icone = Properties.Resources.clienteSelecionado;
                    if (!linhaJaSelecionadaAntes)
                    {
                        _IdVeiculoSelecionado = Guid.Empty;
                        _IdClienteSelecionado = (Guid)grid.Rows[linhaSelecionada].Cells[2].Value;
                    }
                }
                else if (iconeNovo == EnumIcone.VeiculoSelecionado)
                {
                    icone = Properties.Resources.VeiculoSelecionado;
                    if (!linhaJaSelecionadaAntes)
                        _IdVeiculoSelecionado = (Guid)grid.Rows[linhaSelecionada].Cells[2].Value;
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
               
                if (!inclusao)
                    _itens.RemoveAll(x => x.ProdutoServicoId == (Guid)grid.Rows[linhaSelecionada].Cells[1].Value);
                else
                {
                    var item = new OrcamentoItensRequest();
                    item.Tipo = tipo;
                    item.ProdutoServicoId = (Guid)grid.Rows[linhaSelecionada].Cells[1].Value;
                    item.PrecoVenda = Convert.ToDecimal(grid.Rows[linhaSelecionada].Cells[Iprecovenda].Value);
                    
                    if (tipo == EnumTipo.Produto)
                        item.Quantidade = (int)grid.Rows[linhaSelecionada].Cells[3].Value;

                    _itens.Add(item);
                }

                if (tipo == EnumTipo.Servico)
                {
                    txtTotalServico.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Servico).Sum(x => x.PrecoVenda).ToString("N2"));
                    textQuantidadeServico.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Servico).Select(x => x.ProdutoServicoId).Count());
                }
                else
                {
                    txtTotalProdutos.Text = Convert.ToString(_itens.Where(x => x.Tipo == EnumTipo.Produto).Sum(x => x.Quantidade * x.PrecoVenda).ToString("N2"));
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
            ProximoPasso();
        }

        private void ProximoPasso()
        {
            if (tabControlOrcamento.SelectedIndex == 1)
            {
                if ((_IdClienteSelecionado != Guid.Empty) && (_IdClienteSelecionado != null))
                {
                    if (_IdVeiculoSelecionado == Guid.Empty)
                        Passo_2();
                    else
                        Passo_2(false); //Atualiza grid
                }
                else
                {
                    toast.ShowToast(MSG.E_NECESSARIO_SELECIONAR_UM_X0_PARA_PROSSEGUIR.ToFormat("Cliente"), EnumToast.Informacao);
                    this.Focus();
                    dataGridCliente.Focus();
                }
            }
            else if (tabControlOrcamento.SelectedIndex == 2)
                if ((_IdVeiculoSelecionado != Guid.Empty) && (_IdVeiculoSelecionado != null))
                    Passo_3();
                else
                {
                    toast.ShowToast(MSG.E_NECESSARIO_SELECIONAR_UM_X0_PARA_PROSSEGUIR.ToFormat("Veículo"), EnumToast.Informacao);
                    this.Focus();
                    dataGridVeículo.Focus();
                }

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

            txtTotal.Text = ((Convert.ToDecimal(txtTotalProdutos.Text) + Convert.ToDecimal(txtTotalServico.Text) + Convert.ToDecimal(txtAcrescimo.Text)) - Convert.ToDecimal(txtDesconto.Text)).ToString("N2");


        }

        private void dataGridProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SelecionaGrid(dataGridProduto, EnumIcone.ProdutoSelecionado);
                e.Handled = true;
            }

            if (e.KeyCode == Keys.F3)
                e.Handled = true;

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.F2))
            {
                dataGridProduto.SelectedRows[0].Cells[3].Selected = true;
                dataGridProduto.BeginEdit(true);
                e.Handled = true;
            }

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
                this.Size = new Size(1046, 742);
                tabControlOrcamento.Size = new Size(1024, 622);
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (tabControlOrcamento.SelectedIndex != 3)
                    return false;

                if (dataGridProduto == null)
                    return false;

                int icolumn = dataGridProduto.CurrentCell.ColumnIndex;
                int irow = dataGridProduto.CurrentCell.RowIndex;

                if (keyData == Keys.Enter)
                {
                    if (icolumn == dataGridProduto.Columns.Count - 1)
                    {
                        dataGridProduto.Rows.Add();
                        dataGridProduto.CurrentCell = dataGridProduto[0, irow + 1];
                    }
                    else
                    {
                        dataGridProduto.CurrentCell = dataGridProduto[icolumn + 1, irow];
                    }
                    return true;
                }
                else
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            catch 
            {
                return false;
            }

        }
    
        private void dataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaGrid(dataGridProduto, EnumIcone.ProdutoSelecionado);
        }

        private bool EprodutoOUservico(EnumIcone icone)
        {
            return ((icone == EnumIcone.ProdutoSelecionado) || (icone == EnumIcone.ServicoSelecionado));
        }

        private void Salvar()
        {
            try
            {
                _serviceOrcamento.ClearNotifications();
                var orcamentoRequest = new OrcamentoRequest();

                orcamentoRequest.ClienteId = _IdClienteSelecionado;
                orcamentoRequest.VeiculoId = _IdVeiculoSelecionado;
                orcamentoRequest.ValorTotal = txtTotal.Text;
                orcamentoRequest.ValorDesconto = txtDesconto.Text;
                orcamentoRequest.ValorAcrescimo = txtAcrescimo.Text;
                orcamentoRequest.ExisteOrdemServico = false;
                orcamentoRequest.DataCriacao = DateTime.Now;
                orcamentoRequest.Itens = _itens;

                _serviceOrcamento.AdicionarAlterar(orcamentoRequest);

                if (VerificaNotificacoes(_serviceOrcamento))
                {
                    _unitOfWork.SaveChanges();

                    _itens.Clear();
                    AjustaTelaTamanho(0);
                    LimpaPasso3Orcamento();
                    Passo_0("");
                    toast.ShowToast(MSG.X0_SALVO_COM_SUCESSO.ToFormat("Orçamento"), EnumToast.Sucesso);
                }
            }
            catch(Exception ex)
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + " " + ex, EnumToast.Erro);
                txtPesquisarProduto.Focus();
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show("Deseja confirmar exclusão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.No)
                    return;

                _serviceOrcamento.ClearNotifications();

                var orcamento = OrcamentoSelecionado();

                if (orcamento == null)
                    return;

                _serviceOrcamento.Excluir(orcamento.Numero);

                if (VerificaNotificacoes(_serviceOrcamento))
                {
                    _unitOfWork.SaveChanges();
                    Passo_0("");
                    toast.ShowToast(MSG.EXCLUSAO_REALIZADA_COM_SUCESSO, EnumToast.Sucesso);
                    this.Focus();
                    dataGridOrcamento.Focus();
                }
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                this.Focus();
                dataGridOrcamento.Focus();
                return;
            }
        }

        private OrcamentoResponse OrcamentoSelecionado()
        {
            try
            {
                return dataGridOrcamento.SelectedRows[0].DataBoundItem as OrcamentoResponse;
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_AO_SELECIONAR_X0.ToFormat("orçamento") + ex, EnumToast.Erro);
                return null;
            }
        }

        private void lblFinalizar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void dataGridProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Ajustar depois
            SelecionaGrid(dataGridProduto, EnumIcone.ProdutoSelecionado);
            SelecionaGrid(dataGridProduto, EnumIcone.ProdutoSelecionado);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaTelaAlteracaoOrcamento();
        }

        private void LimpaPasso3Orcamento()
        {
            txtCliente.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtPesquisarServico.Text = string.Empty;
            txtPesquisarProduto.Text = string.Empty;
            textQuantidadeServico.Text = "0,00";
            txtTotalServico.Text = "0,00";
            textQuantidadeProduto.Text = "0,00";
            txtTotalProdutos.Text = "0,00";
            txtTotal.Text = "0,00";
            txtAcrescimo.Text = "0,00";
            txtDesconto.Text = "0,00";
        }

        private void CarregaTelaAlteracaoOrcamento()
        {
            try
            {
                var orcamentoSelecionado = OrcamentoSelecionado();

                var orcamento = _serviceOrcamento.Obter_ByNumero(orcamentoSelecionado.Numero);

                _IdClienteSelecionado = orcamento.Cliente.Id.Value;
                //_IdVeiculoSelecionado = orcamento.Cliente.vei
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
