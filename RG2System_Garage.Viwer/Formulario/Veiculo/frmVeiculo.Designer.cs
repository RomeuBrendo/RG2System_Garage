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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1.SuspendLayout();
            this.tpSelecionarVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            this.tpCadastroVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tpSelecionarVeiculo);
            this.metroTabControl1.Controls.Add(this.tpCadastroVeiculo);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 66);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(566, 443);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            // 
            // tpSelecionarVeiculo
            // 
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
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir (DEL)";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(447, 127);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar (F5)";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(447, 88);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo (INS)";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(58, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 13;
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Placa});
            this.dataGridCategoria.EnableHeadersVisualStyles = false;
            this.dataGridCategoria.Location = new System.Drawing.Point(16, 87);
            this.dataGridCategoria.MultiSelect = false;
            this.dataGridCategoria.Name = "dataGridCategoria";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCategoria.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategoria.Size = new System.Drawing.Size(404, 278);
            this.dataGridCategoria.TabIndex = 3;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle15;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 250;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            dataGridViewCellStyle16.NullValue = "False";
            this.Placa.DefaultCellStyle = dataGridViewCellStyle16;
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
            this.tpCadastroVeiculo.Controls.Add(this.textBox3);
            this.tpCadastroVeiculo.Controls.Add(this.label3);
            this.tpCadastroVeiculo.Controls.Add(this.textBox2);
            this.tpCadastroVeiculo.Controls.Add(this.label2);
            this.tpCadastroVeiculo.Controls.Add(this.textBox1);
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
            this.btnCancelarNovo.TabIndex = 22;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(173, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar (F4)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 19;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 17;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 15;
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
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmVeiculo";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Veículo";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroTabControl1.ResumeLayout(false);
            this.tpSelecionarVeiculo.ResumeLayout(false);
            this.tpSelecionarVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            this.tpCadastroVeiculo.ResumeLayout(false);
            this.tpCadastroVeiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}