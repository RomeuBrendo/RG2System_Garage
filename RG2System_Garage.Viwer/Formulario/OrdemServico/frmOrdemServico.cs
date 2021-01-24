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
        List<ORPagamentoResquest> _listaPagamento = new List<ORPagamentoResquest>();

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

            var response = _serviceFormaPagamento.Listar("");

            if (response == null)
                return;

            if (VerificaNotificacoes(_serviceFormaPagamento))
            {
                dataGridFormaPagamento.DataSource = response.OrderBy(x => x.Descricao).ToList();
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

                //pagamento.Valor = (txtFaltaReceber.Text).ToString("c2");
                pagamento.Valor = "0";
                _listaPagamento.Add(pagamento);

                dataGridPagamentos.AutoGenerateColumns = false;
               
                dataGridPagamentos.DataSource = _listaPagamento;
                dataGridFormaPagamento.Update();
                dataGridFormaPagamento.Refresh();
            }
            catch (Exception ex)
            {

                toast.ShowToast(MSG.ERRO_REALIZAR_PROCEDIMENTO + ex, EnumToast.Erro);
                return;
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
    }
}
