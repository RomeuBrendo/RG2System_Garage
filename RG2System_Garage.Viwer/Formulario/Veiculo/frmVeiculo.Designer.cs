namespace RG2System_Garage.Viwer.Formulario.Veiculo
{
    partial class frmVeiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlVeiculo = new MetroFramework.Controls.MetroTabControl();
            this.tpSelecionarVeiculo = new MetroFramework.Controls.MetroTabPage();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridCategoria = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCadastroVeiculo = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelarNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.TabControlVeiculo.SuspendLayout();
            this.tpSelecionarVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            this.tpCadastroVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlVeiculo
            // 
            this.TabControlVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlVeiculo.Controls.Add(this.tpSelecionarVeiculo);
            this.TabControlVeiculo.Controls.Add(this.tpCadastroVeiculo);
            this.TabControlVeiculo.Location = new System.Drawing.Point(3, 66);
            this.TabControlVeiculo.Name = "TabControlVeiculo";
            this.TabControlVeiculo.SelectedIndex = 0;
            this.TabControlVeiculo.Size = new System.Drawing.Size(566, 443);
            this.TabControlVeiculo.Style = MetroFramework.MetroColorStyle.Red;
            this.TabControlVeiculo.TabIndex = 0;
            this.TabControlVeiculo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // tpSelecionarVeiculo
            // 
            this.tpSelecionarVeiculo.Controls.Add(this.btnSair);
            this.tpSelecionarVeiculo.Controls.Add(this.btnExcluir);
            this.tpSelecionarVeiculo.Controls.Add(this.btnAlterar);
            this.tpSelecionarVeiculo.Controls.Add(this.btnNovo);
            this.tpSelecionarVeiculo.Controls.Add(this.txtPesquisar);
            this.tpSelecionarVeiculo.Controls.Add(this.lblPesquisa);
            this.tpSelecionarVeiculo.Controls.Add(this.dataGridCategoria);
            this.tpSelecionarVeiculo.HorizontalScrollbarBarColor = true;
            this.tpSelecionarVeiculo.Location = new System.Drawing.Point(4, 35);
            this.tpSelecionarVeiculo.Name = "tpSelecionarVeiculo";
            this.tpSelecionarVeiculo.Size = new System.Drawing.Size(558, 404);
            this.tpSelecionarVeiculo.TabIndex = 0;
            this.tpSelecionarVeiculo.Text = "tpSelecionarVeiculo";
            this.tpSelecionarVeiculo.VerticalScrollbarBarColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(447, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir (DEL)";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(447, 127);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar (F5)";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(447, 88);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo (INS)";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(58, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(15, 44);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(37, 13);
            this.lblPesquisa.TabIndex = 14;
            this.lblPesquisa.Text = "Placa:";
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.AllowUserToResizeColumns = false;
            this.dataGridCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.White;
            this.dataGridCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle67;
            this.dataGridCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle68;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Placa});
            this.dataGridCategoria.EnableHeadersVisualStyles = false;
            this.dataGridCategoria.Location = new System.Drawing.Point(16, 87);
            this.dataGridCategoria.MultiSelect = false;
            this.dataGridCategoria.Name = "dataGridCategoria";
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dataGridCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCategoria.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dataGridCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategoria.Size = new System.Drawing.Size(404, 278);
            this.dataGridCategoria.TabIndex = 1;
            this.dataGridCategoria.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle69;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 250;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            dataGridViewCellStyle70.NullValue = "False";
            this.Placa.DefaultCellStyle = dataGridViewCellStyle70;
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Placa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Placa.Width = 153;
            // 
            // tpCadastroVeiculo
            // 
            this.tpCadastroVeiculo.Controls.Add(this.btnCancelarNovo);
            this.tpCadastroVeiculo.Controls.Add(this.btnSalvar);
            this.tpCadastroVeiculo.Controls.Add(this.txtModelo);
            this.tpCadastroVeiculo.Controls.Add(this.label3);
            this.tpCadastroVeiculo.Controls.Add(this.txtPlaca);
            this.tpCadastroVeiculo.Controls.Add(this.label2);
            this.tpCadastroVeiculo.Controls.Add(this.txtAno);
            this.tpCadastroVeiculo.Controls.Add(this.label1);
            this.tpCadastroVeiculo.HorizontalScrollbarBarColor = true;
            this.tpCadastroVeiculo.Location = new System.Drawing.Point(4, 35);
            this.tpCadastroVeiculo.Name = "tpCadastroVeiculo";
            this.tpCadastroVeiculo.Size = new System.Drawing.Size(558, 404);
            this.tpCadastroVeiculo.TabIndex = 1;
            this.tpCadastroVeiculo.Text = "tpCadastroVeiculo";
            this.tpCadastroVeiculo.VerticalScrollbarBarColor = true;
            // 
            // btnCancelarNovo
            // 
            this.btnCancelarNovo.Location = new System.Drawing.Point(299, 290);
            this.btnCancelarNovo.Name = "btnCancelarNovo";
            this.btnCancelarNovo.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarNovo.TabIndex = 4;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            this.btnCancelarNovo.Click += new System.EventHandler(this.btnCancelarNovo_Click);
            this.btnCancelarNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(173, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(227, 117);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(162, 20);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtModelo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ano:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(227, 161);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Placa:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(227, 205);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(162, 20);
            this.txtAno.TabIndex = 2;
            this.txtAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyDown);
            this.txtAno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modelo:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 43);
            this.panel1.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(447, 205);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (ESC)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControlVeiculo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVeiculo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Veículo";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmVeiculo_PreviewKeyDown);
            this.TabControlVeiculo.ResumeLayout(false);
            this.tpSelecionarVeiculo.ResumeLayout(false);
            this.tpSelecionarVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            this.tpCadastroVeiculo.ResumeLayout(false);
            this.tpCadastroVeiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControlVeiculo;
        private MetroFramework.Controls.MetroTabPage tpSelecionarVeiculo;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private MetroFramework.Controls.MetroTabPage tpCadastroVeiculo;
        private MetroFramework.Controls.MetroButton btnCancelarNovo;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnSair;
    }
}