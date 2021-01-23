
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlFormaPagamento = new MetroFramework.Controls.MetroTabControl();
            this.tpCadastroForma = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelarNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.panelCadastroFormapagamento = new MetroFramework.Controls.MetroPanel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPrazoRecebimento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dataGridFormaPagamento = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.tpSelecionarForma = new MetroFramework.Controls.MetroTabPage();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrazoRecebimento = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.TabControlFormaPagamento.SuspendLayout();
            this.tpCadastroForma.SuspendLayout();
            this.panelCadastroFormapagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormaPagamento)).BeginInit();
            this.tpSelecionarForma.SuspendLayout();
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
            // tpCadastroForma
            // 
            this.tpCadastroForma.Controls.Add(this.btnCancelarNovo);
            this.tpCadastroForma.Controls.Add(this.btnSalvar);
            this.tpCadastroForma.Controls.Add(this.panelCadastroFormapagamento);
            this.tpCadastroForma.HorizontalScrollbarBarColor = true;
            this.tpCadastroForma.Location = new System.Drawing.Point(4, 35);
            this.tpCadastroForma.Name = "tpCadastroForma";
            this.tpCadastroForma.Size = new System.Drawing.Size(543, 302);
            this.tpCadastroForma.TabIndex = 1;
            this.tpCadastroForma.Text = "tpCadastroForma";
            this.tpCadastroForma.VerticalScrollbarBarColor = true;
            // 
            // btnCancelarNovo
            // 
            this.btnCancelarNovo.Location = new System.Drawing.Point(299, 267);
            this.btnCancelarNovo.Name = "btnCancelarNovo";
            this.btnCancelarNovo.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarNovo.TabIndex = 1;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(173, 267);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar (F4)";
            // 
            // panelCadastroFormapagamento
            // 
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
            this.panelCadastroFormapagamento.Size = new System.Drawing.Size(543, 250);
            this.panelCadastroFormapagamento.TabIndex = 21;
            this.panelCadastroFormapagamento.VerticalScrollbarBarColor = true;
            this.panelCadastroFormapagamento.VerticalScrollbarHighlightOnWheel = false;
            this.panelCadastroFormapagamento.VerticalScrollbarSize = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(137, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(378, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblPrazoRecebimento
            // 
            this.lblPrazoRecebimento.AutoSize = true;
            this.lblPrazoRecebimento.BackColor = System.Drawing.Color.White;
            this.lblPrazoRecebimento.Location = new System.Drawing.Point(28, 121);
            this.lblPrazoRecebimento.Name = "lblPrazoRecebimento";
            this.lblPrazoRecebimento.Size = new System.Drawing.Size(103, 13);
            this.lblPrazoRecebimento.TabIndex = 20;
            this.lblPrazoRecebimento.Text = "Prazo Recebimento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(100, 76);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(73, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dataGridFormaPagamento
            // 
            this.dataGridFormaPagamento.AllowUserToAddRows = false;
            this.dataGridFormaPagamento.AllowUserToDeleteRows = false;
            this.dataGridFormaPagamento.AllowUserToResizeColumns = false;
            this.dataGridFormaPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridFormaPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFormaPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFormaPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Id});
            this.dataGridFormaPagamento.EnableHeadersVisualStyles = false;
            this.dataGridFormaPagamento.Location = new System.Drawing.Point(16, 87);
            this.dataGridFormaPagamento.MultiSelect = false;
            this.dataGridFormaPagamento.Name = "dataGridFormaPagamento";
            this.dataGridFormaPagamento.ReadOnly = true;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFormaPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridFormaPagamento.RowHeadersVisible = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFormaPagamento.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridFormaPagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFormaPagamento.Size = new System.Drawing.Size(404, 185);
            this.dataGridFormaPagamento.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(15, 44);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(55, 13);
            this.lblPesquisa.TabIndex = 14;
            this.lblPesquisa.Text = "Descrição";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(76, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(447, 88);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo (INS)";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(447, 127);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar (F5)";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(447, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir (DEL)";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(447, 205);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (ESC)";
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
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Descricao";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle43;
            this.Modelo.HeaderText = "Descricao";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 404;
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
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Produto",
            "Serviço"});
            this.cmbTipo.Location = new System.Drawing.Point(137, 73);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(290, 21);
            this.cmbTipo.TabIndex = 22;
            this.cmbTipo.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantidade Parcelas:";
            // 
            // txtPrazoRecebimento
            // 
            this.txtPrazoRecebimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrazoRecebimento.Location = new System.Drawing.Point(137, 118);
            this.txtPrazoRecebimento.Name = "txtPrazoRecebimento";
            this.txtPrazoRecebimento.Size = new System.Drawing.Size(45, 20);
            this.txtPrazoRecebimento.TabIndex = 24;
            this.txtPrazoRecebimento.Text = "1";
            this.txtPrazoRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas
            // 
            this.txtParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcelas.Location = new System.Drawing.Point(382, 118);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(45, 20);
            this.txtParcelas.TabIndex = 25;
            this.txtParcelas.Text = "0";
            this.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(572, 432);
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
            this.TabControlFormaPagamento.ResumeLayout(false);
            this.tpCadastroForma.ResumeLayout(false);
            this.panelCadastroFormapagamento.ResumeLayout(false);
            this.panelCadastroFormapagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormaPagamento)).EndInit();
            this.tpSelecionarForma.ResumeLayout(false);
            this.tpSelecionarForma.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtPrazoRecebimento;
    }
}