using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Shared.Formulario.Toast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Orcamento
{
    public partial class frmOrcamento : MetroFramework.Forms.MetroForm
    {
        private IServiceOrcamento _serviceOrcamento;
        private IUnitOfWork _unitOfWork;
        Toast toast = new Toast();
        Guid IdEstaSendoEditado = Guid.Empty;
        public frmOrcamento()
        {
            InitializeComponent();
            ConsultarDepedencias();
        }
        void ConsultarDepedencias()
        {
            _serviceOrcamento = (IServiceOrcamento)Program.ServiceProvider.GetService(typeof(IServiceOrcamento));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));

        }
        private void frmOrcamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
