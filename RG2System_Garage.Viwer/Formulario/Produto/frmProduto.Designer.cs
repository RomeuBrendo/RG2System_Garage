﻿namespace RG2System_Garage.Viwer.Formulario.Produto
{
    partial class frmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlProduto = new MetroFramework.Controls.MetroTabControl();
            this.tpSelecionar = new MetroFramework.Controls.MetroTabPage();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.tpCadastro = new MetroFramework.Controls.MetroTabPage();
            this.panelCadastroProduto = new MetroFramework.Controls.MetroPanel();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new MetroFramework.Controls.MetroLabel();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.lblEstoque = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescrição = new MetroFramework.Controls.MetroLabel();
            this.btnCancelarNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecoCusto = new MetroFramework.Controls.MetroLabel();
            this.tabControlProduto.SuspendLayout();
            this.tpSelecionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.tpCadastro.SuspendLayout();
            this.panelCadastroProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProduto
            // 
            this.tabControlProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProduto.Controls.Add(this.tpSelecionar);
            this.tabControlProduto.Controls.Add(this.tpCadastro);
            this.tabControlProduto.Location = new System.Drawing.Point(3, 63);
            this.tabControlProduto.Name = "tabControlProduto";
            this.tabControlProduto.SelectedIndex = 1;
            this.tabControlProduto.Size = new System.Drawing.Size(566, 437);
            this.tabControlProduto.Style = MetroFramework.MetroColorStyle.Red;
            this.tabControlProduto.TabIndex = 2;
            // 
            // tpSelecionar
            // 
            this.tpSelecionar.Controls.Add(this.btnSair);
            this.tpSelecionar.Controls.Add(this.btnExcluir);
            this.tpSelecionar.Controls.Add(this.btnAlterar);
            this.tpSelecionar.Controls.Add(this.btnNovo);
            this.tpSelecionar.Controls.Add(this.txtPesquisar);
            this.tpSelecionar.Controls.Add(this.lblPesquisa);
            this.tpSelecionar.Controls.Add(this.dataGridProduto);
            this.tpSelecionar.HorizontalScrollbarBarColor = true;
            this.tpSelecionar.Location = new System.Drawing.Point(4, 35);
            this.tpSelecionar.Name = "tpSelecionar";
            this.tpSelecionar.Size = new System.Drawing.Size(558, 398);
            this.tpSelecionar.TabIndex = 0;
            this.tpSelecionar.Text = "tpSelecionar";
            this.tpSelecionar.VerticalScrollbarBarColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(450, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (ESC)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(450, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir (DEL)";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(450, 105);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar (F5)";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(450, 66);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo (INS)";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(61, 19);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(18, 22);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblPesquisa.TabIndex = 14;
            this.lblPesquisa.Text = "Nome:";
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToDeleteRows = false;
            this.dataGridProduto.AllowUserToResizeColumns = false;
            this.dataGridProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            this.dataGridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridProduto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Contato,
            this.Venda,
            this.Id});
            this.dataGridProduto.EnableHeadersVisualStyles = false;
            this.dataGridProduto.Location = new System.Drawing.Point(19, 65);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridProduto.RowHeadersVisible = false;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridProduto.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.Size = new System.Drawing.Size(404, 337);
            this.dataGridProduto.TabIndex = 1;
            this.dataGridProduto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.panelCadastroProduto);
            this.tpCadastro.Controls.Add(this.btnCancelarNovo);
            this.tpCadastro.Controls.Add(this.btnSalvar);
            this.tpCadastro.HorizontalScrollbarBarColor = true;
            this.tpCadastro.Location = new System.Drawing.Point(4, 35);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Size = new System.Drawing.Size(558, 398);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "tpCadastro";
            this.tpCadastro.VerticalScrollbarBarColor = true;
            // 
            // panelCadastroProduto
            // 
            this.panelCadastroProduto.Controls.Add(this.lblPrecoCusto);
            this.panelCadastroProduto.Controls.Add(this.txtPrecoCusto);
            this.panelCadastroProduto.Controls.Add(this.txtPrecoVenda);
            this.panelCadastroProduto.Controls.Add(this.lblPrecoVenda);
            this.panelCadastroProduto.Controls.Add(this.txtEstoqueAtual);
            this.panelCadastroProduto.Controls.Add(this.lblEstoque);
            this.panelCadastroProduto.Controls.Add(this.txtDescricao);
            this.panelCadastroProduto.Controls.Add(this.lblDescrição);
            this.panelCadastroProduto.HorizontalScrollbarBarColor = true;
            this.panelCadastroProduto.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCadastroProduto.HorizontalScrollbarSize = 10;
            this.panelCadastroProduto.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroProduto.Name = "panelCadastroProduto";
            this.panelCadastroProduto.Size = new System.Drawing.Size(555, 175);
            this.panelCadastroProduto.TabIndex = 21;
            this.panelCadastroProduto.VerticalScrollbarBarColor = true;
            this.panelCadastroProduto.VerticalScrollbarHighlightOnWheel = false;
            this.panelCadastroProduto.VerticalScrollbarSize = 10;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoCusto.Location = new System.Drawing.Point(145, 95);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(47, 20);
            this.txtPrecoCusto.TabIndex = 2;
            this.txtPrecoCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoCusto_KeyDown);
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtPrecoCusto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoVenda.Location = new System.Drawing.Point(145, 131);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(47, 20);
            this.txtPrecoVenda.TabIndex = 3;
            this.txtPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtPrecoVenda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(53, 131);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(86, 19);
            this.lblPrecoVenda.TabIndex = 6;
            this.lblPrecoVenda.Text = "Preço Venda:";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstoqueAtual.Location = new System.Drawing.Point(145, 59);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(47, 20);
            this.txtEstoqueAtual.TabIndex = 1;
            this.txtEstoqueAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstoqueAtual_KeyDown);
            this.txtEstoqueAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtEstoqueAtual.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(47, 59);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(92, 19);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque Atual:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(145, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Location = new System.Drawing.Point(71, 24);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(68, 19);
            this.lblDescrição.TabIndex = 2;
            this.lblDescrição.Text = "Descrição:";
            // 
            // btnCancelarNovo
            // 
            this.btnCancelarNovo.Location = new System.Drawing.Point(296, 199);
            this.btnCancelarNovo.Name = "btnCancelarNovo";
            this.btnCancelarNovo.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarNovo.TabIndex = 1;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            this.btnCancelarNovo.Click += new System.EventHandler(this.btnCancelarNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(170, 199);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Descricao";
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle57;
            this.Modelo.HeaderText = "Descrição";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 250;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Estoque";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle58.NullValue = "False";
            this.Contato.DefaultCellStyle = dataGridViewCellStyle58;
            this.Contato.HeaderText = "Estoque";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Contato.Width = 60;
            // 
            // Venda
            // 
            this.Venda.DataPropertyName = "PrecoVenda";
            this.Venda.HeaderText = "Venda";
            this.Venda.Name = "Venda";
            this.Venda.ReadOnly = true;
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
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(56, 96);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 19);
            this.lblPrecoCusto.TabIndex = 7;
            this.lblPrecoCusto.Text = "Preço Custo:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(572, 505);
            this.Controls.Add(this.tabControlProduto);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Produto";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProduto_PreviewKeyDown);
            this.tabControlProduto.ResumeLayout(false);
            this.tpSelecionar.ResumeLayout(false);
            this.tpSelecionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.panelCadastroProduto.ResumeLayout(false);
            this.panelCadastroProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlProduto;
        private MetroFramework.Controls.MetroTabPage tpSelecionar;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private MetroFramework.Controls.MetroTabPage tpCadastro;
        private MetroFramework.Controls.MetroPanel panelCadastroProduto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private MetroFramework.Controls.MetroLabel lblPrecoVenda;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private MetroFramework.Controls.MetroLabel lblEstoque;
        private System.Windows.Forms.TextBox txtDescricao;
        private MetroFramework.Controls.MetroLabel lblDescrição;
        private MetroFramework.Controls.MetroButton btnCancelarNovo;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel lblPrecoCusto;
    }
}