
namespace RG2System_Garage.Viwer.Formulario.FormaPagamento
{
    partial class frmFormaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlFormaPagamento = new MetroFramework.Controls.MetroTabControl();
            this.tpSelecionarForma = new MetroFramework.Controls.MetroTabPage();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridFormaPagamento = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCadastroForma = new MetroFramework.Controls.MetroTabPage();
            this.panelCadastroFormapagamento = new MetroFramework.Controls.MetroPanel();
            this.btnCancelarNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.txtPrazoRecebimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPrazoRecebimento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.TabControlFormaPagamento.SuspendLayout();
            this.tpSelecionarForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormaPagamento)).BeginInit();
            this.tpCadastroForma.SuspendLayout();
            this.panelCadastroFormapagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlFormaPagamento
            // 
            this.TabControlFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlFormaPagamento.Controls.Add(this.tpSelecionarForma);
            this.TabControlFormaPagamento.Controls.Add(this.tpCadastroForma);
            this.TabControlFormaPagamento.Location = new System.Drawing.Point(11, 52);
            this.TabControlFormaPagamento.Name = "TabControlFormaPagamento";
            this.TabControlFormaPagamento.SelectedIndex = 1;
            this.TabControlFormaPagamento.Size = new System.Drawing.Size(551, 341);
            this.TabControlFormaPagamento.Style = MetroFramework.MetroColorStyle.Red;
            this.TabControlFormaPagamento.TabIndex = 1;
            // 
            // tpSelecionarForma
            // 
            this.tpSelecionarForma.Controls.Add(this.btnSair);
            this.tpSelecionarForma.Controls.Add(this.btnExcluir);
            this.tpSelecionarForma.Controls.Add(this.btnAlterar);
            this.tpSelecionarForma.Controls.Add(this.btnNovo);
            this.tpSelecionarForma.Controls.Add(this.txtPesquisar);
            this.tpSelecionarForma.Controls.Add(this.lblPesquisa);
            this.tpSelecionarForma.Controls.Add(this.dataGridFormaPagamento);
            this.tpSelecionarForma.HorizontalScrollbarBarColor = true;
            this.tpSelecionarForma.Location = new System.Drawing.Point(4, 35);
            this.tpSelecionarForma.Name = "tpSelecionarForma";
            this.tpSelecionarForma.Size = new System.Drawing.Size(543, 302);
            this.tpSelecionarForma.TabIndex = 0;
            this.tpSelecionarForma.Text = "tpSelecionarForma";
            this.tpSelecionarForma.VerticalScrollbarBarColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(422, 205);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (ESC)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(422, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir (DEL)";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(422, 127);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar (F5)";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(422, 88);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo (INS)";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(89, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(294, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            this.txtPesquisar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(28, 44);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(55, 13);
            this.lblPesquisa.TabIndex = 14;
            this.lblPesquisa.Text = "Descrição";
            // 
            // dataGridFormaPagamento
            // 
            this.dataGridFormaPagamento.AllowUserToAddRows = false;
            this.dataGridFormaPagamento.AllowUserToDeleteRows = false;
            this.dataGridFormaPagamento.AllowUserToResizeColumns = false;
            this.dataGridFormaPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFormaPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFormaPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFormaPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Id});
            this.dataGridFormaPagamento.EnableHeadersVisualStyles = false;
            this.dataGridFormaPagamento.Location = new System.Drawing.Point(31, 88);
            this.dataGridFormaPagamento.MultiSelect = false;
            this.dataGridFormaPagamento.Name = "dataGridFormaPagamento";
            this.dataGridFormaPagamento.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFormaPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFormaPagamento.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridFormaPagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFormaPagamento.Size = new System.Drawing.Size(354, 185);
            this.dataGridFormaPagamento.TabIndex = 1;
            this.dataGridFormaPagamento.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Modelo.HeaderText = "Descriçao";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 350;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // tpCadastroForma
            // 
            this.tpCadastroForma.Controls.Add(this.panelCadastroFormapagamento);
            this.tpCadastroForma.HorizontalScrollbarBarColor = true;
            this.tpCadastroForma.Location = new System.Drawing.Point(4, 35);
            this.tpCadastroForma.Name = "tpCadastroForma";
            this.tpCadastroForma.Size = new System.Drawing.Size(543, 302);
            this.tpCadastroForma.TabIndex = 1;
            this.tpCadastroForma.Text = "tpCadastroForma";
            this.tpCadastroForma.VerticalScrollbarBarColor = true;
            // 
            // panelCadastroFormapagamento
            // 
            this.panelCadastroFormapagamento.Controls.Add(this.btnCancelarNovo);
            this.panelCadastroFormapagamento.Controls.Add(this.btnSalvar);
            this.panelCadastroFormapagamento.Controls.Add(this.txtParcelas);
            this.panelCadastroFormapagamento.Controls.Add(this.txtPrazoRecebimento);
            this.panelCadastroFormapagamento.Controls.Add(this.label1);
            this.panelCadastroFormapagamento.Controls.Add(this.cmbTipo);
            this.panelCadastroFormapagamento.Controls.Add(this.txtDescricao);
            this.panelCadastroFormapagamento.Controls.Add(this.lblPrazoRecebimento);
            this.panelCadastroFormapagamento.Controls.Add(this.lblTipo);
            this.panelCadastroFormapagamento.Controls.Add(this.lblDescricao);
            this.panelCadastroFormapagamento.HorizontalScrollbarBarColor = true;
            this.panelCadastroFormapagamento.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCadastroFormapagamento.HorizontalScrollbarSize = 10;
            this.panelCadastroFormapagamento.Location = new System.Drawing.Point(0, 11);
            this.panelCadastroFormapagamento.Name = "panelCadastroFormapagamento";
            this.panelCadastroFormapagamento.Size = new System.Drawing.Size(543, 278);
            this.panelCadastroFormapagamento.TabIndex = 21;
            this.panelCadastroFormapagamento.VerticalScrollbarBarColor = true;
            this.panelCadastroFormapagamento.VerticalScrollbarHighlightOnWheel = false;
            this.panelCadastroFormapagamento.VerticalScrollbarSize = 10;
            // 
            // btnCancelarNovo
            // 
            this.btnCancelarNovo.Location = new System.Drawing.Point(293, 251);
            this.btnCancelarNovo.Name = "btnCancelarNovo";
            this.btnCancelarNovo.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarNovo.TabIndex = 5;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            this.btnCancelarNovo.Click += new System.EventHandler(this.btnCancelarNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(167, 251);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtParcelas
            // 
            this.txtParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcelas.Location = new System.Drawing.Point(140, 160);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(45, 20);
            this.txtParcelas.TabIndex = 3;
            this.txtParcelas.Text = "0";
            this.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazoRecebimento_KeyPress);
            this.txtParcelas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // txtPrazoRecebimento
            // 
            this.txtPrazoRecebimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrazoRecebimento.Location = new System.Drawing.Point(140, 118);
            this.txtPrazoRecebimento.Name = "txtPrazoRecebimento";
            this.txtPrazoRecebimento.Size = new System.Drawing.Size(45, 20);
            this.txtPrazoRecebimento.TabIndex = 2;
            this.txtPrazoRecebimento.Text = "0";
            this.txtPrazoRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrazoRecebimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazoRecebimento_KeyPress);
            this.txtPrazoRecebimento.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantidade Parcelas:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "À Vista",
            "Cartão Débito",
            "Cartão Crédito",
            "Deposito Bancário",
            "Dinheiro a Prazo",
            "Cheque",
            "Outros"});
            this.cmbTipo.Location = new System.Drawing.Point(140, 73);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(149, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.Tag = "";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipo_KeyDown);
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.cmbTipo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(140, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(378, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            // 
            // lblPrazoRecebimento
            // 
            this.lblPrazoRecebimento.AutoSize = true;
            this.lblPrazoRecebimento.BackColor = System.Drawing.Color.White;
            this.lblPrazoRecebimento.Location = new System.Drawing.Point(31, 121);
            this.lblPrazoRecebimento.Name = "lblPrazoRecebimento";
            this.lblPrazoRecebimento.Size = new System.Drawing.Size(103, 13);
            this.lblPrazoRecebimento.TabIndex = 20;
            this.lblPrazoRecebimento.Text = "Prazo Recebimento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(103, 76);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(76, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // panelTabControl
            // 
            this.panelTabControl.Location = new System.Drawing.Point(11, 52);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(551, 43);
            this.panelTabControl.TabIndex = 19;
            // 
            // frmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(572, 432);
            this.Controls.Add(this.panelTabControl);
            this.Controls.Add(this.TabControlFormaPagamento);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaPagamento";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Forma de Pagamento";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.frmFormaPagamento_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmFormaPagamento_PreviewKeyDown);
            this.TabControlFormaPagamento.ResumeLayout(false);
            this.tpSelecionarForma.ResumeLayout(false);
            this.tpSelecionarForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormaPagamento)).EndInit();
            this.tpCadastroForma.ResumeLayout(false);
            this.panelCadastroFormapagamento.ResumeLayout(false);
            this.panelCadastroFormapagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControlFormaPagamento;
        private MetroFramework.Controls.MetroTabPage tpCadastroForma;
        private MetroFramework.Controls.MetroButton btnCancelarNovo;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroPanel panelCadastroFormapagamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblPrazoRecebimento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescricao;
        private MetroFramework.Controls.MetroTabPage tpSelecionarForma;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridFormaPagamento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtPrazoRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel panelTabControl;
    }
}