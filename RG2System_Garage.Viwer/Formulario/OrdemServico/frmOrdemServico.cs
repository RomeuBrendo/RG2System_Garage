using prmToolkit.NotificationPattern.Extensions;
using RG2System_Garage.Domain.Commands.FormaPagamento;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Commands.OrdemServico;
using RG2System_Garage.Domain.Enum;
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
        private IServiceOrdemServico _serviceOrcamento;
        private IServiceFormaPagamento _serviceFormaPagamento;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid _idEstaSendoEditado;
        OrcamentoResponse _orcamentoResponse;
        List<ORPagamentoResquest> _listaPagamentoSelecionados = new List<ORPagamentoResquest>();
        List<FormaPagamentoResponse> _listaPagamento = new List<FormaPagamentoResponse>();
        public frmOrdemServico(OrcamentoResponse orcamentoResponse)
        {
            InitializeComponent();
            ConsultarDepedencias();

            _orcamentoResponse = orcamentoResponse;
            if (_orcamentoResponse != null)
                CarregaComponentesEstaticos();

        }

        void ConsultarDepedencias()
        {
            _serviceOrcamento = (IServiceOrdemServico)Program.ServiceProvider.GetService(typeof(IServiceOrdemServico));
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
              
                AtualizaGridFormaPagamentoSelecionada();


            }
            catch (Exception ex)
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                return;
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
                    grid.SelectedRows[0].Cells[cell].Value = txtFaltaReceber.Text;

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
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                CalculeTotais();
                e.Handled = true;
            }
        }

        private void rbFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.Green;
            datePrazoFinalizacao.Enabled = true;
            datePrazoFinalizacao.Focus();
        }

        private void rbEmAndamento_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.DarkRed;
            datePrazoFinalizacao.Enabled = false;
        }

        private void rdAguardando_CheckedChanged(object sender, EventArgs e)
        {
            panelCorStatus.BackColor = Color.DarkRed;
            datePrazoFinalizacao.Enabled = false;
        }
    }
}
