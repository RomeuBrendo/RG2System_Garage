using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {

        bool glb_HideMenu;

        public frmPrincipal()
        {
            InitializeComponent();
            pnMenu.Left = -304;
            glb_HideMenu = true;
            HideAllMenu();
        }

        private void tmMenu_Tick(object sender, EventArgs e)
        {
            if (glb_HideMenu)
            {
                label1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                pnMenu.Left += 16;
                tabControl1.Left += 16;
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
                tabControl1.Left -= 16;
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
            tabControl1.SelectedIndex = 3;
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnLancServico_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnConfigGeral_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
    }
}
