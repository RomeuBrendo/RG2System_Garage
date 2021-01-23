using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
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
        private IUnitOfWork _unitOfWork;
        public frmOrdemServico()
        {
            InitializeComponent();
            ConsultarDepedencias();
        }

        void ConsultarDepedencias()
        {
            _serviceOrcamento = (IServiceOrdemServico)Program.ServiceProvider.GetService(typeof(IServiceOrdemServico));
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
                //toast.ShowToast("Erro ao limpar campos. Detalhes: " + ex, EnumToast.Erro);
                return;
            }

        }
    }
}
