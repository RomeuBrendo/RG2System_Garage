namespace RG2System_Garage.Viwer.Formulario.Cliente
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlCliente = new MetroFramework.Controls.MetroTabControl();
            this.tpSelecionar = new MetroFramework.Controls.MetroTabPage();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCadastro = new MetroFramework.Controls.MetroTabPage();
            this.panelCadastroVeiculo = new MetroFramework.Controls.MetroPanel();
            this.lblAdicionarVeiculo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new MetroFramework.Controls.MetroLabel();
            this.lblVeiculosAssociados = new MetroFramework.Controls.MetroLabel();
            this.dataGridVeiculo = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.lblTelefone1 = new MetroFramework.Controls.MetroLabel();
            this.txtCPFCPNJ = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.btnCancelarNovo = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.tabControlCliente.SuspendLayout();
            this.tpSelecionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.tpCadastro.SuspendLayout();
            this.panelCadastroVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCliente.Controls.Add(this.tpSelecionar);
            this.tabControlCliente.Controls.Add(this.tpCadastro);
            this.tabControlCliente.Location = new System.Drawing.Point(3, 63);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 1;
            this.tabControlCliente.Size = new System.Drawing.Size(566, 437);
            this.tabControlCliente.Style = MetroFramework.MetroColorStyle.Red;
            this.tabControlCliente.TabIndex = 1;
            // 
            // tpSelecionar
            // 
            this.tpSelecionar.Controls.Add(this.btnSair);
            this.tpSelecionar.Controls.Add(this.btnExcluir);
            this.tpSelecionar.Controls.Add(this.btnAlterar);
            this.tpSelecionar.Controls.Add(this.btnNovo);
            this.tpSelecionar.Controls.Add(this.txtPesquisar);
            this.tpSelecionar.Controls.Add(this.lblPesquisa);
            this.tpSelecionar.Controls.Add(this.dataGridCliente);
            this.tpSelecionar.HorizontalScrollbarBarColor = true;
            this.tpSelecionar.Location = new System.Drawing.Point(4, 35);
            this.tpSelecionar.Name = "tpSelecionar";
            this.tpSelecionar.Size = new System.Drawing.Size(558, 398);
            this.tpSelecionar.TabIndex = 0;
            this.tpSelecionar.Text = "tpSelecionar";
            this.tpSelecionar.VerticalScrollbarBarColor = true;
            this.tpSelecionar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(450, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (ESC)";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(450, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir (DEL)";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(450, 105);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar (F5)";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(450, 66);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo (INS)";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(61, 19);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
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
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.AllowUserToResizeColumns = false;
            this.dataGridCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Contato,
            this.Id});
            this.dataGridCliente.EnableHeadersVisualStyles = false;
            this.dataGridCliente.Location = new System.Drawing.Point(19, 65);
            this.dataGridCliente.MultiSelect = false;
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCliente.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCliente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCliente.Size = new System.Drawing.Size(404, 337);
            this.dataGridCliente.TabIndex = 1;
            this.dataGridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellDoubleClick);
            this.dataGridCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridCliente_KeyDown);
            this.dataGridCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.dataGridCliente.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Modelo.HeaderText = "Nome";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 250;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Telefone1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.NullValue = "False";
            this.Contato.DefaultCellStyle = dataGridViewCellStyle4;
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Contato.Width = 153;
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
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.panelCadastroVeiculo);
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
            // panelCadastroVeiculo
            // 
            this.panelCadastroVeiculo.Controls.Add(this.lblAdicionarVeiculo);
            this.panelCadastroVeiculo.Controls.Add(this.txtPlaca);
            this.panelCadastroVeiculo.Controls.Add(this.lblPlaca);
            this.panelCadastroVeiculo.Controls.Add(this.lblVeiculosAssociados);
            this.panelCadastroVeiculo.Controls.Add(this.dataGridVeiculo);
            this.panelCadastroVeiculo.Controls.Add(this.txtTelefone2);
            this.panelCadastroVeiculo.Controls.Add(this.txtTelefone1);
            this.panelCadastroVeiculo.Controls.Add(this.lblTelefone1);
            this.panelCadastroVeiculo.Controls.Add(this.txtCPFCPNJ);
            this.panelCadastroVeiculo.Controls.Add(this.lblCpfCnpj);
            this.panelCadastroVeiculo.Controls.Add(this.txtNome);
            this.panelCadastroVeiculo.Controls.Add(this.lblNome);
            this.panelCadastroVeiculo.HorizontalScrollbarBarColor = true;
            this.panelCadastroVeiculo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCadastroVeiculo.HorizontalScrollbarSize = 10;
            this.panelCadastroVeiculo.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroVeiculo.Name = "panelCadastroVeiculo";
            this.panelCadastroVeiculo.Size = new System.Drawing.Size(555, 357);
            this.panelCadastroVeiculo.TabIndex = 21;
            this.panelCadastroVeiculo.VerticalScrollbarBarColor = true;
            this.panelCadastroVeiculo.VerticalScrollbarHighlightOnWheel = false;
            this.panelCadastroVeiculo.VerticalScrollbarSize = 10;
            // 
            // lblAdicionarVeiculo
            // 
            this.lblAdicionarVeiculo.BackColor = System.Drawing.Color.White;
            this.lblAdicionarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdicionarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("lblAdicionarVeiculo.Image")));
            this.lblAdicionarVeiculo.Location = new System.Drawing.Point(256, 169);
            this.lblAdicionarVeiculo.Name = "lblAdicionarVeiculo";
            this.lblAdicionarVeiculo.Size = new System.Drawing.Size(39, 26);
            this.lblAdicionarVeiculo.TabIndex = 20;
            this.lblAdicionarVeiculo.Click += new System.EventHandler(this.lblAdicionarVeiculo_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(139, 175);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(111, 20);
            this.txtPlaca.TabIndex = 9;
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(90, 175);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(43, 19);
            this.lblPlaca.TabIndex = 8;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblVeiculosAssociados
            // 
            this.lblVeiculosAssociados.AutoSize = true;
            this.lblVeiculosAssociados.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVeiculosAssociados.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVeiculosAssociados.Location = new System.Drawing.Point(196, 133);
            this.lblVeiculosAssociados.Name = "lblVeiculosAssociados";
            this.lblVeiculosAssociados.Size = new System.Drawing.Size(171, 25);
            this.lblVeiculosAssociados.TabIndex = 7;
            this.lblVeiculosAssociados.Text = "Veículos Associados";
            // 
            // dataGridVeiculo
            // 
            this.dataGridVeiculo.AllowUserToOrderColumns = true;
            this.dataGridVeiculo.AllowUserToResizeColumns = false;
            this.dataGridVeiculo.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridVeiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridVeiculo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVeiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVeiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridVeiculo.EnableHeadersVisualStyles = false;
            this.dataGridVeiculo.Location = new System.Drawing.Point(68, 210);
            this.dataGridVeiculo.MultiSelect = false;
            this.dataGridVeiculo.Name = "dataGridVeiculo";
            this.dataGridVeiculo.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVeiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridVeiculo.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVeiculo.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVeiculo.Size = new System.Drawing.Size(404, 144);
            this.dataGridVeiculo.TabIndex = 4;
            this.dataGridVeiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridVeiculo_KeyDown);
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Placa.Width = 153;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone2.Location = new System.Drawing.Point(256, 99);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(111, 20);
            this.txtTelefone2.TabIndex = 3;
            this.txtTelefone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone2_KeyDown);
            this.txtTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtTelefone2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone1.Location = new System.Drawing.Point(139, 99);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(111, 20);
            this.txtTelefone1.TabIndex = 2;
            this.txtTelefone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone1_KeyDown);
            this.txtTelefone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtTelefone1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(73, 100);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(60, 19);
            this.lblTelefone1.TabIndex = 6;
            this.lblTelefone1.Text = "Telefone:";
            // 
            // txtCPFCPNJ
            // 
            this.txtCPFCPNJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPFCPNJ.Location = new System.Drawing.Point(139, 62);
            this.txtCPFCPNJ.Name = "txtCPFCPNJ";
            this.txtCPFCPNJ.Size = new System.Drawing.Size(111, 20);
            this.txtCPFCPNJ.TabIndex = 1;
            this.txtCPFCPNJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPFCPNJ_KeyDown);
            this.txtCPFCPNJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtCPFCPNJ.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(53, 62);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(80, 19);
            this.lblCpfCnpj.TabIndex = 4;
            this.lblCpfCnpj.Text = "CPF/CNPPJ:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(139, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // btnCancelarNovo
            // 
            this.btnCancelarNovo.Location = new System.Drawing.Point(299, 372);
            this.btnCancelarNovo.Name = "btnCancelarNovo";
            this.btnCancelarNovo.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarNovo.TabIndex = 1;
            this.btnCancelarNovo.Text = "Cancelar (ESC)";
            this.btnCancelarNovo.Click += new System.EventHandler(this.btnCancelarNovo_Click);
            this.btnCancelarNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(173, 372);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            // 
            // panel
            // 
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(7, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(562, 48);
            this.panel.TabIndex = 15;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(572, 505);
            this.Controls.Add(this.tabControlCliente);
            this.Controls.Add(this.panel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Cliente";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmCliente_PreviewKeyDown);
            this.tabControlCliente.ResumeLayout(false);
            this.tpSelecionar.ResumeLayout(false);
            this.tpSelecionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.panelCadastroVeiculo.ResumeLayout(false);
            this.panelCadastroVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlCliente;
        private MetroFramework.Controls.MetroTabPage tpSelecionar;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private MetroFramework.Controls.MetroTabPage tpCadastro;
        private MetroFramework.Controls.MetroButton btnCancelarNovo;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroPanel panelCadastroVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.TextBox txtTelefone1;
        private MetroFramework.Controls.MetroLabel lblTelefone1;
        private System.Windows.Forms.TextBox txtCPFCPNJ;
        private MetroFramework.Controls.MetroLabel lblCpfCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.DataGridView dataGridVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblAdicionarVeiculo;
        private System.Windows.Forms.TextBox txtPlaca;
        private MetroFramework.Controls.MetroLabel lblPlaca;
        private MetroFramework.Controls.MetroLabel lblVeiculosAssociados;
        private MetroFramework.Controls.MetroPanel panel;
    }
}