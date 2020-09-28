namespace RG2System_Garage.Viwer.Formulario
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnConfiguracoes = new System.Windows.Forms.Panel();
            this.btnConfigGeral = new System.Windows.Forms.Button();
            this.pnLancamentos = new System.Windows.Forms.Panel();
            this.btnLancServico = new System.Windows.Forms.Button();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnLancamento = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.tmMenu = new System.Windows.Forms.Timer(this.components);
            this.panelformularios = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnConfiguracoes.SuspendLayout();
            this.pnLancamentos.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.pnMenu.Controls.Add(this.pnConfiguracoes);
            this.pnMenu.Controls.Add(this.pnLancamentos);
            this.pnMenu.Controls.Add(this.pnCadastro);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnConfiguracao);
            this.pnMenu.Controls.Add(this.btnLancamento);
            this.pnMenu.Controls.Add(this.btnCadastro);
            this.pnMenu.Location = new System.Drawing.Point(0, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(368, 540);
            this.pnMenu.TabIndex = 0;
            // 
            // pnConfiguracoes
            // 
            this.pnConfiguracoes.Controls.Add(this.btnConfigGeral);
            this.pnConfiguracoes.Location = new System.Drawing.Point(-1, 498);
            this.pnConfiguracoes.Name = "pnConfiguracoes";
            this.pnConfiguracoes.Size = new System.Drawing.Size(368, 40);
            this.pnConfiguracoes.TabIndex = 9;
            // 
            // btnConfigGeral
            // 
            this.btnConfigGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfigGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigGeral.FlatAppearance.BorderSize = 0;
            this.btnConfigGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigGeral.ForeColor = System.Drawing.Color.White;
            this.btnConfigGeral.Location = new System.Drawing.Point(0, 0);
            this.btnConfigGeral.Name = "btnConfigGeral";
            this.btnConfigGeral.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfigGeral.Size = new System.Drawing.Size(368, 40);
            this.btnConfigGeral.TabIndex = 5;
            this.btnConfigGeral.Text = "GERAL";
            this.btnConfigGeral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigGeral.UseVisualStyleBackColor = false;
            this.btnConfigGeral.Click += new System.EventHandler(this.btnConfigGeral_Click);
            // 
            // pnLancamentos
            // 
            this.pnLancamentos.Controls.Add(this.btnLancServico);
            this.pnLancamentos.Location = new System.Drawing.Point(-1, 418);
            this.pnLancamentos.Name = "pnLancamentos";
            this.pnLancamentos.Size = new System.Drawing.Size(368, 40);
            this.pnLancamentos.TabIndex = 8;
            // 
            // btnLancServico
            // 
            this.btnLancServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLancServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancServico.FlatAppearance.BorderSize = 0;
            this.btnLancServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancServico.ForeColor = System.Drawing.Color.White;
            this.btnLancServico.Location = new System.Drawing.Point(0, 0);
            this.btnLancServico.Name = "btnLancServico";
            this.btnLancServico.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLancServico.Size = new System.Drawing.Size(368, 40);
            this.btnLancServico.TabIndex = 5;
            this.btnLancServico.Text = "PRODUTOS/SERVIÇOS";
            this.btnLancServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancServico.UseVisualStyleBackColor = false;
            this.btnLancServico.Click += new System.EventHandler(this.btnLancServico_Click);
            // 
            // pnCadastro
            // 
            this.pnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnCadastro.Controls.Add(this.btnCadVeiculo);
            this.pnCadastro.Controls.Add(this.btnCadProduto);
            this.pnCadastro.Controls.Add(this.btnCadCliente);
            this.pnCadastro.Location = new System.Drawing.Point(0, 259);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(368, 119);
            this.pnCadastro.TabIndex = 4;
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVeiculo.FlatAppearance.BorderSize = 0;
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadVeiculo.Location = new System.Drawing.Point(0, 80);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadVeiculo.Size = new System.Drawing.Size(368, 40);
            this.btnCadVeiculo.TabIndex = 7;
            this.btnCadVeiculo.Text = "VEÍCULO";
            this.btnCadVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVeiculo.UseVisualStyleBackColor = false;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.FlatAppearance.BorderSize = 0;
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadProduto.Location = new System.Drawing.Point(0, 40);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadProduto.Size = new System.Drawing.Size(368, 40);
            this.btnCadProduto.TabIndex = 6;
            this.btnCadProduto.Text = "PRODUTO";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCliente.FlatAppearance.BorderSize = 0;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadCliente.Size = new System.Drawing.Size(368, 40);
            this.btnCadCliente.TabIndex = 5;
            this.btnCadCliente.Text = "CLIENTE";
            this.btnCadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(305, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 35);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Location = new System.Drawing.Point(1, 458);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfiguracao.Size = new System.Drawing.Size(364, 40);
            this.btnConfiguracao.TabIndex = 2;
            this.btnConfiguracao.Text = "CONFIGURAÇÕES";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnLancamento
            // 
            this.btnLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnLancamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancamento.FlatAppearance.BorderSize = 0;
            this.btnLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamento.ForeColor = System.Drawing.Color.White;
            this.btnLancamento.Location = new System.Drawing.Point(1, 378);
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLancamento.Size = new System.Drawing.Size(364, 40);
            this.btnLancamento.TabIndex = 1;
            this.btnLancamento.Text = "LANÇAMENTOS";
            this.btnLancamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamento.UseVisualStyleBackColor = false;
            this.btnLancamento.Click += new System.EventHandler(this.btnLancamento_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(1, 219);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(364, 40);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // tmMenu
            // 
            this.tmMenu.Interval = 5;
            this.tmMenu.Tick += new System.EventHandler(this.tmMenu_Tick);
            // 
            // panelformularios
            // 
            this.panelformularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelformularios.Location = new System.Drawing.Point(3, 42);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(769, 484);
            this.panelformularios.TabIndex = 36;
            this.panelformularios.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 542);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panelformularios);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnMenu.ResumeLayout(false);
            this.pnConfiguracoes.ResumeLayout(false);
            this.pnLancamentos.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnLancamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmMenu;
        private System.Windows.Forms.Panel pnLancamentos;
        private System.Windows.Forms.Button btnLancServico;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Panel pnConfiguracoes;
        private System.Windows.Forms.Button btnConfigGeral;
        private System.Windows.Forms.Panel panelformularios;
    }
}