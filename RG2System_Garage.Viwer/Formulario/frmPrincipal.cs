using RG2System_Garage.Viwer.Formulario.Cliente;
using RG2System_Garage.Viwer.Formulario.Configuracao;
using RG2System_Garage.Viwer.Formulario.Orcamento;
using RG2System_Garage.Viwer.Formulario.Produto;
using RG2System_Garage.Viwer.Formulario.Veiculo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {

        bool glb_HideMenu;

        private static readonly List<Thread> _threads = new List<Thread>();

        public frmPrincipal()
        {
            InitializeComponent();
            pnMenu.Left = -304;
            panelformularios.Width -= (pnMenu.Width - 304);
            panelformularios.Left += (pnMenu.Width - 304);
            glb_HideMenu = true;
            HideAllMenu();

            Thread t1 = new Thread(new ThreadStart(run));
            CarregaThreadAjusteForm();
        }

        private void CarregaThreadAjusteForm()
        {
            Thread t1 = new Thread(new ThreadStart(run));
            t1.Priority = ThreadPriority.Lowest;
            t1.Name = "Secundária";
            _threads.Add(t1);
            t1.Start();
            //t1.Abort();
        }

        //Será necessario melhorar este processo posteriormente.
        public void run()
        {
            while (true)
            {
                AjustarPosicaoForms();

                if (_threads.Count < 1)
                    return;

                Thread.Sleep(300);
            }
        }

        public void AjustarPosicaoForms()
        {
            if (panelformularios.Controls.Count > 0)
                panelformularios.BeginInvoke(
                    new Action (() =>
                    {
                        for (int i = 0; i < panelformularios.Controls.Count; i++)
                        {
                            panelformularios.Controls[i].Left = (panelformularios.Width - panelformularios.Controls[i].Width) / 2;
                            panelformularios.Controls[i].Top = (panelformularios.Height - panelformularios.Controls[i].Height) / 2;
                        }
                    }));
        }

        private void tmMenu_Tick(object sender, EventArgs e)
        {
            if (glb_HideMenu)
            {
                label1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                
                pnMenu.Left += 16;

                panelformularios.Width -= 16;
                panelformularios.Left += 16;
                AjustarPosicaoForms();

                if (pnMenu.Left == 0)
                {
                    glb_HideMenu = false;
                    this.Refresh();
                    tmMenu.Stop();
                }
            }
            else
            {
                HideAllMenu();
                label1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pnMenu.Left -= 16;

                panelformularios.Left -= 16;
                panelformularios.Width += 16;
                AjustarPosicaoForms();

                if (pnMenu.Left == -304)
                {
                    glb_HideMenu = true;
                    this.Refresh();                
                    tmMenu.Stop();

                }
            }
        }

        public void HideAllMenu()
        {
            btnCadastro.Top = 219;
            btnLancamento.Top = 219 + btnCadastro.Height;
            btnConfiguracao.Top = btnLancamento.Top + btnLancamento.Height;
            pnCadastro.Visible = false;
            pnLancamentos.Visible = false;
            pnConfiguracoes.Visible = false;
        }

        public void ShowSubMenu(Panel Painel)
        {
            HideAllMenu();
            if (Painel.Name == "pnCadastro")
            {
                btnLancamento.Top = btnLancamento.Top + pnCadastro.Height;
                btnConfiguracao.Top = btnConfiguracao.Top + pnCadastro.Height;
                Painel.Top = 219 + btnCadastro.Height;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnLancamentos")
            {
                btnConfiguracao.Top = btnConfiguracao.Top + pnLancamentos.Height;
                Painel.Top = btnLancamento.Top + btnLancamento.Height;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnConfiguracoes")
            {
                Painel.Top = btnConfiguracao.Top + btnConfiguracao.Height;
                Painel.Visible = true;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            tmMenu.Start();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (pnCadastro.Visible)
                HideAllMenu();
            else
                ShowSubMenu(pnCadastro); 
        }

        private void btnLancamento_Click(object sender, EventArgs e)
        {
            if (pnLancamentos.Visible)
                HideAllMenu();
            else
                ShowSubMenu(pnLancamentos);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            if (pnConfiguracoes.Visible)
                HideAllMenu();
            else
                ShowSubMenu(pnConfiguracoes);
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVeiculo>(false);
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCliente>(false);
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProdutoServico>(false);
        }

        private void btnLancServico_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmOrcamento>(false);
        }

        private void btnConfigGeral_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDadosEmpresa>(false);
        }

        private void AbrirFormulario<formNovo>(Boolean abrirEmShowModal) where formNovo : Form, new()
        {

            var frmForm = panelformularios.Controls.OfType<formNovo>().FirstOrDefault();

            if (frmForm == null)
            {
                frmForm = new formNovo();
                frmForm.TopLevel = false;
                frmForm.FormBorderStyle = FormBorderStyle.None;
                panelformularios.Controls.Add(frmForm);
                panelformularios.Visible = true;
              
                if (abrirEmShowModal)
                    frmForm.ShowDialog();
                else
                    frmForm.Show();

                frmForm.BringToFront();
          
            }
            else
            {
                frmForm.BringToFront();
                frmForm.WindowState = FormWindowState.Normal;
                
            }

            AjustarPosicaoForms();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            var threads = _threads.ToList();
            
            foreach (var thread in threads)
                _threads.Remove(thread); 

        }
    }
}
