using System.Windows.Forms;

namespace RG2System_Garage.Viwer.Formulario.Produto
{
    public partial class frmProduto : MetroFramework.Forms.MetroForm
    {
        public frmProduto()
        {
            InitializeComponent();
            tabControlProduto.SelectedIndex = 0;
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            this.Text = "Novo Produto";
            tabControlProduto.SelectedIndex = 1;
            this.Height = 340;
            this.Refresh();
            txtDescricao.Focus();
        }

        private void btnAlterar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            if (tabControlProduto.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.Insert)
                    btnNovo.PerformClick();

                if (e.KeyCode == Keys.F5)
                    btnAlterar.PerformClick();

                if (e.KeyCode == Keys.Delete)
                    btnExcluir.PerformClick();

                if (e.KeyCode == Keys.Escape)
                    btnSair.PerformClick();
            }

            if (tabControlProduto.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Escape)
                    btnCancelarNovo.PerformClick();

                if (e.KeyCode == Keys.F4)
                    btnSalvar.PerformClick();
            }
        }

        private void btnCancelarNovo_Click(object sender, System.EventArgs e)
        {
            tabControlProduto.SelectedIndex = 0;
            LimparCampos();
        }

        public void LimparCampos()
        {
            foreach (Control item in this.panelCadastroProduto.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }

            this.Text = "Selecionar Produto";
            this.Height = 505;
            this.Refresh();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) || (e.KeyChar == 27))
                e.Handled = true;
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEstoqueAtual.Focus();
        }

        private void txtEstoqueAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoCusto.Focus();
        }

        private void txtPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoVenda.Focus();
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDescricao.Focus();
        }
    }
}
