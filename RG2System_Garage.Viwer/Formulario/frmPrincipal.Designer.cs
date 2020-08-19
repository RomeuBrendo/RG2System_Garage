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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpCliente = new MetroFramework.Controls.MetroTabPage();
            this.tpProduto = new MetroFramework.Controls.MetroTabPage();
            this.tpVeiculo = new MetroFramework.Controls.MetroTabPage();
            this.tpLancamento = new MetroFramework.Controls.MetroTabPage();
            this.tpConfig = new MetroFramework.Controls.MetroTabPage();
            this.gridVeiculo = new System.Windows.Forms.DataGridView();
            this.btnNovoVeiculo = new MetroFramework.Controls.MetroButton();
            this.btnAlterarVeiculo = new MetroFramework.Controls.MetroButton();
            this.btnExcluirVeiculo = new MetroFramework.Controls.MetroButton();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarVeiculo = new MetroFramework.Controls.MetroButton();
            this.btnSalvarVeiculo = new MetroFramework.Controls.MetroButton();
            this.btnVerificaClienteVinculado = new MetroFramework.Controls.MetroButton();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarCliente = new MetroFramework.Controls.MetroButton();
            this.btnSalvarCliente = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluirCliente = new MetroFramework.Controls.MetroButton();
            this.btnAlterarCliente = new MetroFramework.Controls.MetroButton();
            this.btnNovoCliente = new MetroFramework.Controls.MetroButton();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarProduto = new MetroFramework.Controls.MetroButton();
            this.btnSalvarProduto = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExcluirProduto = new MetroFramework.Controls.MetroButton();
            this.btnAlterarProduto = new MetroFramework.Controls.MetroButton();
            this.btnNovoProduto = new MetroFramework.Controls.MetroButton();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpHome = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnConfiguracoes.SuspendLayout();
            this.pnLancamentos.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCliente.SuspendLayout();
            this.tpProduto.SuspendLayout();
            this.tpVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.Controls.Add(this.pnConfiguracoes);
            this.pnMenu.Controls.Add(this.pnLancamentos);
            this.pnMenu.Controls.Add(this.pnCadastro);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnConfiguracao);
            this.pnMenu.Controls.Add(this.btnLancamento);
            this.pnMenu.Controls.Add(this.btnCadastro);
            this.pnMenu.Location = new System.Drawing.Point(0, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(368, 717);
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
            this.btnConfigGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(194)))), ((int)(((byte)(217)))));
            this.btnConfigGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigGeral.FlatAppearance.BorderSize = 0;
            this.btnConfigGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigGeral.Font = new System.Drawing.Font("Baloo Tamma 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLancServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(194)))), ((int)(((byte)(217)))));
            this.btnLancServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancServico.FlatAppearance.BorderSize = 0;
            this.btnLancServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancServico.Font = new System.Drawing.Font("Baloo Tamma 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCadVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(194)))), ((int)(((byte)(217)))));
            this.btnCadVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVeiculo.FlatAppearance.BorderSize = 0;
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVeiculo.Font = new System.Drawing.Font("Baloo Tamma 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadVeiculo.Location = new System.Drawing.Point(0, 80);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadVeiculo.Size = new System.Drawing.Size(368, 40);
            this.btnCadVeiculo.TabIndex = 7;
            this.btnCadVeiculo.Text = "VEICULO";
            this.btnCadVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVeiculo.UseVisualStyleBackColor = false;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(194)))), ((int)(((byte)(217)))));
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.FlatAppearance.BorderSize = 0;
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.Font = new System.Drawing.Font("Baloo Tamma 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(194)))), ((int)(((byte)(217)))));
            this.btnCadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCliente.FlatAppearance.BorderSize = 0;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Baloo Tamma 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(305, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 35);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Baloo Tamma 2", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.btnLancamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancamento.FlatAppearance.BorderSize = 0;
            this.btnLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamento.Font = new System.Drawing.Font("Baloo Tamma 2", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Baloo Tamma 2", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpHome);
            this.tabControl1.Controls.Add(this.tpVeiculo);
            this.tabControl1.Controls.Add(this.tpProduto);
            this.tabControl1.Controls.Add(this.tpCliente);
            this.tabControl1.Controls.Add(this.tpLancamento);
            this.tabControl1.Controls.Add(this.tpConfig);
            this.tabControl1.Location = new System.Drawing.Point(65, 28);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 674);
            this.tabControl1.TabIndex = 1;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.btnCancelarCliente);
            this.tpCliente.Controls.Add(this.btnSalvarCliente);
            this.tpCliente.Controls.Add(this.label5);
            this.tpCliente.Controls.Add(this.txtNome);
            this.tpCliente.Controls.Add(this.btnExcluirCliente);
            this.tpCliente.Controls.Add(this.btnAlterarCliente);
            this.tpCliente.Controls.Add(this.btnNovoCliente);
            this.tpCliente.Controls.Add(this.gridCliente);
            this.tpCliente.HorizontalScrollbarBarColor = true;
            this.tpCliente.Location = new System.Drawing.Point(4, 38);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Size = new System.Drawing.Size(1078, 632);
            this.tpCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "metroTabPage1";
            this.tpCliente.VerticalScrollbarBarColor = true;
            // 
            // tpProduto
            // 
            this.tpProduto.Controls.Add(this.label6);
            this.tpProduto.Controls.Add(this.textBox2);
            this.tpProduto.Controls.Add(this.btnCancelarProduto);
            this.tpProduto.Controls.Add(this.btnSalvarProduto);
            this.tpProduto.Controls.Add(this.label4);
            this.tpProduto.Controls.Add(this.textBox1);
            this.tpProduto.Controls.Add(this.btnExcluirProduto);
            this.tpProduto.Controls.Add(this.btnAlterarProduto);
            this.tpProduto.Controls.Add(this.btnNovoProduto);
            this.tpProduto.Controls.Add(this.gridProduto);
            this.tpProduto.HorizontalScrollbarBarColor = true;
            this.tpProduto.Location = new System.Drawing.Point(4, 38);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Size = new System.Drawing.Size(1078, 632);
            this.tpProduto.TabIndex = 1;
            this.tpProduto.Text = "metroTabPage2";
            this.tpProduto.VerticalScrollbarBarColor = true;
            // 
            // tpVeiculo
            // 
            this.tpVeiculo.Controls.Add(this.btnVerificaClienteVinculado);
            this.tpVeiculo.Controls.Add(this.btnCancelarVeiculo);
            this.tpVeiculo.Controls.Add(this.btnSalvarVeiculo);
            this.tpVeiculo.Controls.Add(this.label3);
            this.tpVeiculo.Controls.Add(this.label2);
            this.tpVeiculo.Controls.Add(this.txtModelo);
            this.tpVeiculo.Controls.Add(this.txtPlaca);
            this.tpVeiculo.Controls.Add(this.btnExcluirVeiculo);
            this.tpVeiculo.Controls.Add(this.btnAlterarVeiculo);
            this.tpVeiculo.Controls.Add(this.btnNovoVeiculo);
            this.tpVeiculo.Controls.Add(this.gridVeiculo);
            this.tpVeiculo.HorizontalScrollbarBarColor = true;
            this.tpVeiculo.Location = new System.Drawing.Point(4, 38);
            this.tpVeiculo.Name = "tpVeiculo";
            this.tpVeiculo.Size = new System.Drawing.Size(1078, 632);
            this.tpVeiculo.TabIndex = 2;
            this.tpVeiculo.Text = "metroTabPage3";
            this.tpVeiculo.VerticalScrollbarBarColor = true;
            // 
            // tpLancamento
            // 
            this.tpLancamento.HorizontalScrollbarBarColor = true;
            this.tpLancamento.Location = new System.Drawing.Point(4, 38);
            this.tpLancamento.Name = "tpLancamento";
            this.tpLancamento.Size = new System.Drawing.Size(1078, 632);
            this.tpLancamento.TabIndex = 3;
            this.tpLancamento.Text = "metroTabPage4";
            this.tpLancamento.VerticalScrollbarBarColor = true;
            // 
            // tpConfig
            // 
            this.tpConfig.HorizontalScrollbarBarColor = true;
            this.tpConfig.Location = new System.Drawing.Point(4, 38);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Size = new System.Drawing.Size(1078, 632);
            this.tpConfig.TabIndex = 4;
            this.tpConfig.Text = "metroTabPage5";
            this.tpConfig.VerticalScrollbarBarColor = true;
            // 
            // gridVeiculo
            // 
            this.gridVeiculo.AllowUserToAddRows = false;
            this.gridVeiculo.AllowUserToDeleteRows = false;
            this.gridVeiculo.AllowUserToResizeColumns = false;
            this.gridVeiculo.AllowUserToResizeRows = false;
            this.gridVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVeiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.gridVeiculo.ColumnHeadersHeight = 21;
            this.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clPlaca,
            this.clModelo});
            this.gridVeiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridVeiculo.Location = new System.Drawing.Point(18, 26);
            this.gridVeiculo.MultiSelect = false;
            this.gridVeiculo.Name = "gridVeiculo";
            this.gridVeiculo.RowHeadersVisible = false;
            this.gridVeiculo.RowHeadersWidth = 137;
            this.gridVeiculo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gridVeiculo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVeiculo.Size = new System.Drawing.Size(1041, 324);
            this.gridVeiculo.TabIndex = 4;
            // 
            // btnNovoVeiculo
            // 
            this.btnNovoVeiculo.Location = new System.Drawing.Point(18, 373);
            this.btnNovoVeiculo.Name = "btnNovoVeiculo";
            this.btnNovoVeiculo.Size = new System.Drawing.Size(111, 23);
            this.btnNovoVeiculo.TabIndex = 5;
            this.btnNovoVeiculo.Text = "NOVO";
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(18, 420);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(111, 23);
            this.btnAlterarVeiculo.TabIndex = 6;
            this.btnAlterarVeiculo.Text = "ALTERAR";
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(18, 467);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirVeiculo.TabIndex = 7;
            this.btnExcluirVeiculo.Text = "EXCLUIR";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(516, 436);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(516, 485);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(462, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo:";
            // 
            // btnCancelarVeiculo
            // 
            this.btnCancelarVeiculo.Location = new System.Drawing.Point(18, 558);
            this.btnCancelarVeiculo.Name = "btnCancelarVeiculo";
            this.btnCancelarVeiculo.Size = new System.Drawing.Size(111, 23);
            this.btnCancelarVeiculo.TabIndex = 13;
            this.btnCancelarVeiculo.Text = "CANCELAR";
            this.btnCancelarVeiculo.Visible = false;
            // 
            // btnSalvarVeiculo
            // 
            this.btnSalvarVeiculo.Location = new System.Drawing.Point(18, 511);
            this.btnSalvarVeiculo.Name = "btnSalvarVeiculo";
            this.btnSalvarVeiculo.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarVeiculo.TabIndex = 12;
            this.btnSalvarVeiculo.Text = "SALVAR";
            this.btnSalvarVeiculo.Visible = false;
            // 
            // btnVerificaClienteVinculado
            // 
            this.btnVerificaClienteVinculado.Location = new System.Drawing.Point(18, 607);
            this.btnVerificaClienteVinculado.Name = "btnVerificaClienteVinculado";
            this.btnVerificaClienteVinculado.Size = new System.Drawing.Size(184, 23);
            this.btnVerificaClienteVinculado.TabIndex = 14;
            this.btnVerificaClienteVinculado.Text = "VERIFICAR CLIENTE VINCULADO";
            // 
            // clId
            // 
            this.clId.HeaderText = "ID";
            this.clId.Name = "clId";
            this.clId.Visible = false;
            // 
            // clPlaca
            // 
            this.clPlaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPlaca.HeaderText = "PLACA";
            this.clPlaca.Name = "clPlaca";
            // 
            // clModelo
            // 
            this.clModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clModelo.HeaderText = "MODELO";
            this.clModelo.Name = "clModelo";
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(18, 558);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(111, 23);
            this.btnCancelarCliente.TabIndex = 24;
            this.btnCancelarCliente.Text = "CANCELAR";
            this.btnCancelarCliente.Visible = false;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(18, 511);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarCliente.TabIndex = 23;
            this.btnSalvarCliente.Text = "SALVAR";
            this.btnSalvarCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(411, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(454, 430);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 19;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(18, 467);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirCliente.TabIndex = 18;
            this.btnExcluirCliente.Text = "EXCLUIR";
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(18, 420);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(111, 23);
            this.btnAlterarCliente.TabIndex = 17;
            this.btnAlterarCliente.Text = "ALTERAR";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(18, 373);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(111, 23);
            this.btnNovoCliente.TabIndex = 16;
            this.btnNovoCliente.Text = "NOVO";
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToAddRows = false;
            this.gridCliente.AllowUserToDeleteRows = false;
            this.gridCliente.AllowUserToResizeColumns = false;
            this.gridCliente.AllowUserToResizeRows = false;
            this.gridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.gridCliente.ColumnHeadersHeight = 21;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clNome});
            this.gridCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCliente.Location = new System.Drawing.Point(18, 26);
            this.gridCliente.MultiSelect = false;
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.RowHeadersVisible = false;
            this.gridCliente.RowHeadersWidth = 137;
            this.gridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gridCliente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(1041, 324);
            this.gridCliente.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // clNome
            // 
            this.clNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNome.HeaderText = "NOME";
            this.clNome.Name = "clNome";
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(18, 558);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnCancelarProduto.TabIndex = 32;
            this.btnCancelarProduto.Text = "CANCELAR";
            this.btnCancelarProduto.Visible = false;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(18, 511);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarProduto.TabIndex = 31;
            this.btnSalvarProduto.Text = "SALVAR";
            this.btnSalvarProduto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Descricao:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 29;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(18, 467);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirProduto.TabIndex = 28;
            this.btnExcluirProduto.Text = "EXCLUIR";
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(18, 420);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnAlterarProduto.TabIndex = 27;
            this.btnAlterarProduto.Text = "ALTERAR";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(18, 373);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(111, 23);
            this.btnNovoProduto.TabIndex = 26;
            this.btnNovoProduto.Text = "NOVO";
            // 
            // gridProduto
            // 
            this.gridProduto.AllowUserToAddRows = false;
            this.gridProduto.AllowUserToDeleteRows = false;
            this.gridProduto.AllowUserToResizeColumns = false;
            this.gridProduto.AllowUserToResizeRows = false;
            this.gridProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.gridProduto.ColumnHeadersHeight = 21;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdProduto,
            this.clDescricaoProduto,
            this.clEstoqueProduto});
            this.gridProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridProduto.Location = new System.Drawing.Point(18, 26);
            this.gridProduto.MultiSelect = false;
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.RowHeadersWidth = 137;
            this.gridProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gridProduto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(1041, 324);
            this.gridProduto.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(397, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Estoque:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 470);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 33;
            // 
            // clIdProduto
            // 
            this.clIdProduto.HeaderText = "ID";
            this.clIdProduto.Name = "clIdProduto";
            this.clIdProduto.Visible = false;
            // 
            // clDescricaoProduto
            // 
            this.clDescricaoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDescricaoProduto.HeaderText = "DESCRIÇÃO";
            this.clDescricaoProduto.Name = "clDescricaoProduto";
            // 
            // clEstoqueProduto
            // 
            this.clEstoqueProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEstoqueProduto.HeaderText = "ESTOQUE";
            this.clEstoqueProduto.Name = "clEstoqueProduto";
            // 
            // tpHome
            // 
            this.tpHome.HorizontalScrollbarBarColor = true;
            this.tpHome.Location = new System.Drawing.Point(4, 38);
            this.tpHome.Name = "tpHome";
            this.tpHome.Size = new System.Drawing.Size(1078, 632);
            this.tpHome.TabIndex = 5;
            this.tpHome.Text = "metroTabPage1";
            this.tpHome.VerticalScrollbarBarColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(65, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 58);
            this.panel1.TabIndex = 35;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 719);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnMenu.ResumeLayout(false);
            this.pnConfiguracoes.ResumeLayout(false);
            this.pnLancamentos.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            this.tpProduto.ResumeLayout(false);
            this.tpProduto.PerformLayout();
            this.tpVeiculo.ResumeLayout(false);
            this.tpVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
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
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tpCliente;
        private MetroFramework.Controls.MetroTabPage tpProduto;
        private MetroFramework.Controls.MetroTabPage tpVeiculo;
        private MetroFramework.Controls.MetroTabPage tpLancamento;
        private MetroFramework.Controls.MetroTabPage tpConfig;
        private MetroFramework.Controls.MetroButton btnExcluirVeiculo;
        private MetroFramework.Controls.MetroButton btnAlterarVeiculo;
        private MetroFramework.Controls.MetroButton btnNovoVeiculo;
        private System.Windows.Forms.DataGridView gridVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private MetroFramework.Controls.MetroButton btnCancelarVeiculo;
        private MetroFramework.Controls.MetroButton btnSalvarVeiculo;
        private MetroFramework.Controls.MetroButton btnVerificaClienteVinculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private MetroFramework.Controls.MetroButton btnCancelarCliente;
        private MetroFramework.Controls.MetroButton btnSalvarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private MetroFramework.Controls.MetroButton btnExcluirCliente;
        private MetroFramework.Controls.MetroButton btnAlterarCliente;
        private MetroFramework.Controls.MetroButton btnNovoCliente;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroButton btnCancelarProduto;
        private MetroFramework.Controls.MetroButton btnSalvarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btnExcluirProduto;
        private MetroFramework.Controls.MetroButton btnAlterarProduto;
        private MetroFramework.Controls.MetroButton btnNovoProduto;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstoqueProduto;
        private MetroFramework.Controls.MetroTabPage tpHome;
        private System.Windows.Forms.Panel panel1;
    }
}