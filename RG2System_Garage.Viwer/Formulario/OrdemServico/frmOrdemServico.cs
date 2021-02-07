using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Domain.Enum.Ordem_Servico;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Interfaces.Services.Base;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using RG2System_Garage.Viwer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.OrdemServico
{
    public partial class frmOrdemServico : MetroFramework.Forms.MetroForm
    {
        private IServiceOrdemServico _serviceOrdemServico;
        private IServiceFormaPagamento _serviceFormaPagamento;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        int _radioButonSelecionado = 1;
        Guid _idEstaSendoEditado;
        OrcamentoResponse _orcamentoResponse;
        List<ORPagamentoResquest> _listaPagamentoSelecionados = new List<ORPagamentoResquest>();
        List<FormaPagamentoResponse> _listaPagamento = new List<FormaPagamentoResponse>();
        public frmOrdemServico(OrcamentoResponse orcamentoResponse)
        {
            InitializeComponent();
            ConsultarDepedencias();
            _idEstaSendoEditado = Guid.Empty;
            _orcamentoResponse = orcamentoResponse;
            if (_orcamentoResponse != null)
                CarregaComponentesEstaticos();

        }

        void ConsultarDepedencias()
        {
            _serviceOrdemServico = (IServiceOrdemServico)Program.ServiceProvider.GetService(typeof(IServiceOrdemServico));
            _serviceFormaPagamento = (IServiceFormaPagamento)Program.ServiceProvider.GetService(typeof(IServiceFormaPagamento));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

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
                return;
            }

        }

        void CarregaComponentesEstaticos()
        {
            try
            {
                CarregaGridFormaPagamento();
                txtCliente.Text = _orcamentoResponse.Cliente.Nome;
                txtPlaca.Text = _orcamentoResponse.Veiculo.Placa;
                txtNumeroOrcamento.Text = Convert.ToString(_orcamentoResponse.Numero);
                txtOrcamentoTotal.Text = _orcamentoResponse.ValorTotal.ToString("N2");
                txtFaltaReceber.Text = _orcamentoResponse.ValorTotal.ToString("N2");

                rbEmAndamento.Checked = true; //Fazer trativa, quando for edição
            }
            catch (Exception ex)
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                return;
            }
        }


        void CarregaGridFormaPagamento()
        {
            dataGridFormaPagamento.DataSource = null;
            dataGridFormaPagamento.AutoGenerateColumns = false;
            dataGridFormaPagamento.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _listaPagamento = _serviceFormaPagamento.Listar("");

            if (_listaPagamento == null)
                return;

            if (VerificaNotificacoes(_serviceFormaPagamento))
            {
                dataGridFormaPagamento.DataSource = _listaPagamento.OrderBy(x => x.Descricao).ToList();
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

                if (tabControlOR.SelectedIndex == 0)
                    txtPesquisar.Focus();
                else
                    dataGridFormaPagamento.Focus();

                return false;
            }
            return true;
        }

        private void lblAdicionarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                var formaPagamento = FormaPagamentoSelecionado();

                var pagamento = new ORPagamentoResquest();
                
                pagamento.FormaPagamentoId = formaPagamento.Id.Value;
                pagamento.Descricao = formaPagamento.Descricao;

                txtFaltaReceber.Text = txtFaltaReceber.Text.Replace("R$", "");
                if (decimal.TryParse(txtFaltaReceber.Text, out decimal valor))
                    pagamento.Valor = valor;

                _listaPagamentoSelecionados.Add(pagamento);
  
                foreach (var item in _listaPagamento.Where(item => item.Id == pagamento.FormaPagamentoId))
                {
                    _listaPagamento.Remove(item);
                    dataGridFormaPagamento.DataSource = _listaPagamento;
                    break;
                }

                AtualizaGridFormaPagamentoSelecionada();


            }
            catch (Exception ex)
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                
            }
        }

        private void AtualizaGridFormaPagamentoSelecionada()
        {
            dataGridPagamentos.AutoGenerateColumns = false;
            dataGridPagamentos.DataSource = null;
            dataGridPagamentos.DataSource = _listaPagamentoSelecionados;
            dataGridPagamentos.Update();
            dataGridPagamentos.Refresh();

            dataGridPagamentos[1, _listaPagamentoSelecionados.Count - 1].Selected = true;
            ColocaEmEdicaoCellDataGrid(dataGridPagamentos, 1);
        }

        private void CalculeTotais()
        {
            try
            {
                var totalSelecionado = _listaPagamentoSelecionados.ToList().Sum(x => x.Valor);
                var faltaReceber = Decimal.Parse(txtOrcamentoTotal.Text) - totalSelecionado;
                
                if (faltaReceber < 0)
                {
                    MessageBox.Show("Soma das formas de pagamento recebidas, está superior o valor total.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ColocaEmEdicaoCellDataGrid(dataGridPagamentos, 1);
                    return;
                }

                txtFaltaReceber.Text = faltaReceber.ToString("C2");
                txtTotalRelacionado.Text = totalSelecionado.ToString("C2");

            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_AO_SELECIONAR_X0.ToFormat("Forma pagamento") + ex, EnumToast.Erro);
            }
        }

        private FormaPagamentoResponse FormaPagamentoSelecionado()
        {
            try
            {
                return dataGridFormaPagamento.SelectedRows[0].DataBoundItem as FormaPagamentoResponse;
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_AO_SELECIONAR_X0.ToFormat("Forma pagamento") + ex, EnumToast.Erro);
                return null;
            }
        }

        private void dataGridPagamentos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculeTotais();
        }

        private void ColocaEmEdicaoCellDataGrid(DataGridView grid, int cell)
        {
            ColocaEmEdicaoCellDataGrid(grid, cell, -1);
        }
        private void ColocaEmEdicaoCellDataGrid(DataGridView grid, int cell, decimal valor)
        {
            try
            {
                grid.SelectedRows[0].Cells[cell].Selected = true;

                if (valor >= 0)
                    grid.SelectedRows[0].Cells[cell].Value = valor.ToString("C2");
                else
                    grid.SelectedRows[0].Cells[cell].Value = txtFaltaReceber.Text.Replace("R$", "");

                grid.BeginEdit(true);
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_AO_SELECIONAR_X0.ToFormat("Forma pagamento") + ex, EnumToast.Erro);   
            }
        }
        private void dataGridPagamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.F2))
            {
                ColocaEmEdicaoCellDataGrid(dataGridPagamentos, 1);
                CalculeTotais();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                CalculeTotais();                
            }
        }

        private void rbFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.Green;
            datePrazoFinalizacao.Enabled = true;
            datePrazoFinalizacao.Focus();
            _radioButonSelecionado = 2;
        }

        private void rbEmAndamento_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.DarkRed;
            _radioButonSelecionado = 1;
            datePrazoFinalizacao.Enabled = false;
        }

        private void rdAguardando_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.DarkRed;
            datePrazoFinalizacao.Enabled = false;
            _radioButonSelecionado = 0;
        }

        private void btnCancelarNovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SalvarOR()
        {
            try
            {
                var ordemServico = new OrdemServicoRequest();
                var pagamentosSelecionados = dataGridPagamentos.DataSource;

                ordemServico.Id = _idEstaSendoEditado;
                ordemServico.OrcamentoId = _orcamentoResponse.Id;
                ordemServico.FormaPagamentos = (List<ORPagamentoResquest>)pagamentosSelecionados;

                if (datePrazoFinalizacao.Enabled)
                    ordemServico.DataFinalizacao = datePrazoFinalizacao.Value;
                else
                    ordemServico.DataFinalizacao = DateTime.MinValue;

                ordemServico.Observacao = txtObservacao.Text;
                ordemServico.Status = (EnumStatus)_radioButonSelecionado;

                _serviceOrdemServico.AdicionarAlterar(ordemServico);

                if (VerificaNotificacoes(_serviceOrdemServico))
                {
                    _unitOfWork.SaveChanges();

                    _listaPagamento.Clear();

                    toast.ShowToast(MSG.X0_SALVA_COM_SUCESSO.ToFormat("Ordem Servico"), EnumToast.Sucesso);
                    
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarOR();
        }
    }
}
