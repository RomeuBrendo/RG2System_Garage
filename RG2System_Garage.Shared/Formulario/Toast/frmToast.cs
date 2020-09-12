using RG2System_Garage.Domain.Enum;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace RG2System_Garage.Shared.Formulario.Toast
{
    public partial class frmToast : Form
    {
        public frmToast(String Message, EnumToast Action)
        {
            InitializeComponent();

            Info.Visible = false;
            error.Visible = false;
            okay.Visible = false;

            lblMenssagem.Text = "";
            lblMenssagem.Text = Message;

            if (Action == EnumToast.Sucesso)
            {
                this.BackColor = Color.FromArgb(43, 148, 50);
                okay.Visible = true;
            }
            else if (Action == EnumToast.Erro)
            {
                this.BackColor = Color.FromArgb(255, 80, 66);
                error.Visible = true;
            }
            else if (Action == EnumToast.Informacao)
            {
                this.BackColor = Color.FromArgb(66, 147, 255);
                Info.Visible = true;
            }
        }

        private void frmToast_Load(object sender, EventArgs e)
        {
            ArredondaCantosdoForm();
            Top = 40;
            Left = Screen.PrimaryScreen.Bounds.Width - 342;
            PosicionaAbaixoCasoJaExistaAlgumAberto();
            TimerClose.Start();
        }

        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        void PosicionaAbaixoCasoJaExistaAlgumAberto()
        {
            var formsAberto = Application.OpenForms.OfType<frmToast>().Count();

            if(formsAberto > 1)
            {
                this.Top += this.Height * (formsAberto - 1); 
            }
        }
    }
}
