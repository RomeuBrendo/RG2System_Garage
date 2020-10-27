namespace RG2System_Garage.Viwer.Formulario.Orcamento
{
    partial class frmOrcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlOrcamento = new MetroFramework.Controls.MetroTabControl();
            this.PageSelecionar = new MetroFramework.Controls.MetroTabPage();
            this.btnOrdemServico = new MetroFramework.Controls.MetroButton();
            this.btnVisualizar = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAlterar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new MetroFramework.Controls.MetroLabel();
            this.dataGridOrcamento = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCliente = new MetroFramework.Controls.MetroTabPage();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.textPesquisaCliente = new System.Windows.Forms.TextBox();
            this.lblProximo = new System.Windows.Forms.Label();
            this.lblRetornar = new System.Windows.Forms.Label();
            this.toolTipOrcamento = new System.Windows.Forms.ToolTip(this.components);
            this.lblCancelar = new System.Windows.Forms.Label();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlOrcamento.SuspendLayout();
            this.PageSelecionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrcamento)).BeginInit();
            this.PageCliente.SuspendLayout();
            this.panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrcamento
            // 
            this.tabControlOrcamento.Controls.Add(this.PageSelecionar);
            this.tabControlOrcamento.Controls.Add(this.PageCliente);
            this.tabControlOrcamento.Location = new System.Drawing.Point(18, 53);
            this.tabControlOrcamento.Name = "tabControlOrcamento";
            this.tabControlOrcamento.SelectedIndex = 1;
            this.tabControlOrcamento.Size = new System.Drawing.Size(807, 558);
            this.tabControlOrcamento.TabIndex = 0;
            // 
            // PageSelecionar
            // 
            this.PageSelecionar.Controls.Add(this.btnOrdemServico);
            this.PageSelecionar.Controls.Add(this.btnVisualizar);
            this.PageSelecionar.Controls.Add(this.btnSair);
            this.PageSelecionar.Controls.Add(this.btnExcluir);
            this.PageSelecionar.Controls.Add(this.btnAlterar);
            this.PageSelecionar.Controls.Add(this.btnNovo);
            this.PageSelecionar.Controls.Add(this.txtPesquisar);
            this.PageSelecionar.Controls.Add(this.lblPesquisar);
            this.PageSelecionar.Controls.Add(this.dataGridOrcamento);
            this.PageSelecionar.HorizontalScrollbarBarColor = true;
            this.PageSelecionar.Location = new System.Drawing.Point(4, 35);
            this.PageSelecionar.Name = "PageSelecionar";
            this.PageSelecionar.Size = new System.Drawing.Size(799, 519);
            this.PageSelecionar.TabIndex = 0;
            this.PageSelecionar.Text = "Selecionar";
            this.PageSelecionar.VerticalScrollbarBarColor = true;
            // 
            // btnOrdemServico
            // 
            this.btnOrdemServico.Location = new System.Drawing.Point(681, 180);
            this.btnOrdemServico.Name = "btnOrdemServico";
            this.btnOrdemServico.Size = new System.Drawing.Size(90, 23);
            this.btnOrdemServico.TabIndex = 11;
            this.btnOrdemServico.Text = "Gerar O. Serviço";
            this.toolTipOrcamento.SetToolTip(this.btnOrdemServico, "Gerar Ordem de Serviço");
            this.btnOrdemServico.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(681, 141);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(90, 23);
            this.btnVisualizar.TabIndex = 10;
            this.btnVisualizar.Text = "Visualizar (V)";
            this.toolTipOrcamento.SetToolTip(this.btnVisualizar, "Visualizar em PDF Orçamento");
            this.btnVisualizar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(681, 258);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 22);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair (ESC)";
            this.toolTipOrcamento.SetToolTip(this.btnSair, "Sair da Tela");
            this.btnSair.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(681, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir (DEL)";
            this.toolTipOrcamento.SetToolTip(this.btnExcluir, "Excluir Orçamento");
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(681, 102);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar (F5)";
            this.toolTipOrcamento.SetToolTip(this.btnAlterar, "Alterar Orçamento Selecionado");
            this.btnAlterar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(681, 63);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo (INS)";
            this.toolTipOrcamento.SetToolTip(this.btnNovo, "Novo Orçamento");
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(87, 21);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(543, 20);
            this.txtPesquisar.TabIndex = 4;
            this.txtPesquisar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(23, 21);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(52, 19);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Cliente:";
            // 
            // dataGridOrcamento
            // 
            this.dataGridOrcamento.AllowUserToDeleteRows = false;
            this.dataGridOrcamento.AllowUserToResizeColumns = false;
            this.dataGridOrcamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridOrcamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOrcamento.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOrcamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Cliente,
            this.Data,
            this.Valor,
            this.Id});
            this.dataGridOrcamento.EnableHeadersVisualStyles = false;
            this.dataGridOrcamento.Location = new System.Drawing.Point(29, 63);
            this.dataGridOrcamento.MultiSelect = false;
            this.dataGridOrcamento.Name = "dataGridOrcamento";
            this.dataGridOrcamento.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridOrcamento.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridOrcamento.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrcamento.Size = new System.Drawing.Size(601, 453);
            this.dataGridOrcamento.TabIndex = 2;
            this.dataGridOrcamento.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Numero";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tipo.HeaderText = "Número";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cliente.Width = 300;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataCriacao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.NullValue = "False";
            this.Data.DefaultCellStyle = dataGridViewCellStyle5;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 120;
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
            // PageCliente
            // 
            this.PageCliente.Controls.Add(this.panelCliente);
            this.PageCliente.HorizontalScrollbarBarColor = true;
            this.PageCliente.Location = new System.Drawing.Point(4, 35);
            this.PageCliente.Name = "PageCliente";
            this.PageCliente.Size = new System.Drawing.Size(799, 519);
            this.PageCliente.TabIndex = 1;
            this.PageCliente.Text = "Cliente";
            this.PageCliente.VerticalScrollbarBarColor = true;
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.Controls.Add(this.dataGridCliente);
            this.panelCliente.Controls.Add(this.lblPesquisa);
            this.panelCliente.Controls.Add(this.textPesquisaCliente);
            this.panelCliente.Location = new System.Drawing.Point(19, 20);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(757, 478);
            this.panelCliente.TabIndex = 18;
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.AllowUserToResizeColumns = false;
            this.dataGridCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Modelo,
            this.dataGridViewTextBoxColumn1});
            this.dataGridCliente.EnableHeadersVisualStyles = false;
            this.dataGridCliente.Location = new System.Drawing.Point(201, 92);
            this.dataGridCliente.MultiSelect = false;
            this.dataGridCliente.Name = "dataGridCliente";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridCliente.RowHeadersVisible = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCliente.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCliente.Size = new System.Drawing.Size(404, 337);
            this.dataGridCliente.TabIndex = 18;
            this.dataGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellContentClick);
            this.dataGridCliente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellValueChanged);
            this.dataGridCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridCliente_KeyDown);
            this.dataGridCliente.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(195, 26);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Nome:";
            // 
            // textPesquisaCliente
            // 
            this.textPesquisaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisaCliente.Location = new System.Drawing.Point(240, 23);
            this.textPesquisaCliente.Name = "textPesquisaCliente";
            this.textPesquisaCliente.Size = new System.Drawing.Size(362, 20);
            this.textPesquisaCliente.TabIndex = 15;
            this.textPesquisaCliente.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // lblProximo
            // 
            this.lblProximo.BackColor = System.Drawing.Color.White;
            this.lblProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProximo.Image = ((System.Drawing.Image)(resources.GetObject("lblProximo.Image")));
            this.lblProximo.Location = new System.Drawing.Point(445, 4);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.Size = new System.Drawing.Size(52, 49);
            this.lblProximo.TabIndex = 6;
            this.lblProximo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipOrcamento.SetToolTip(this.lblProximo, "Proxímo");
            this.lblProximo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // lblRetornar
            // 
            this.lblRetornar.BackColor = System.Drawing.Color.White;
            this.lblRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRetornar.Image = ((System.Drawing.Image)(resources.GetObject("lblRetornar.Image")));
            this.lblRetornar.Location = new System.Drawing.Point(335, 4);
            this.lblRetornar.Name = "lblRetornar";
            this.lblRetornar.Size = new System.Drawing.Size(52, 49);
            this.lblRetornar.TabIndex = 7;
            this.toolTipOrcamento.SetToolTip(this.lblRetornar, "Retornar");
            this.lblRetornar.Click += new System.EventHandler(this.lblRetornar_Click);
            this.lblRetornar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // lblCancelar
            // 
            this.lblCancelar.BackColor = System.Drawing.Color.White;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.Image = ((System.Drawing.Image)(resources.GetObject("lblCancelar.Image")));
            this.lblCancelar.Location = new System.Drawing.Point(3, 4);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(52, 49);
            this.lblCancelar.TabIndex = 8;
            this.toolTipOrcamento.SetToolTip(this.lblCancelar, "Cancelar Processo");
            this.lblCancelar.Click += new System.EventHandler(this.label1_Click);
            this.lblCancelar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.lblProximo);
            this.panelSubMenu.Controls.Add(this.lblCancelar);
            this.panelSubMenu.Controls.Add(this.lblRetornar);
            this.panelSubMenu.Location = new System.Drawing.Point(6, 610);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(833, 58);
            this.panelSubMenu.TabIndex = 9;
            this.panelSubMenu.Visible = false;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 20;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Nome";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle11;
            this.Modelo.HeaderText = "Nome";
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.Width = 383;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(842, 691);
            this.Controls.Add(this.tabControlOrcamento);
            this.Controls.Add(this.panelSubMenu);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrcamento";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selecionar Orçamento";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Shown += new System.EventHandler(this.frmOrcamento_Shown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmOrcamento_PreviewKeyDown);
            this.tabControlOrcamento.ResumeLayout(false);
            this.PageSelecionar.ResumeLayout(false);
            this.PageSelecionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrcamento)).EndInit();
            this.PageCliente.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlOrcamento;
        private MetroFramework.Controls.MetroTabPage PageSelecionar;
        private System.Windows.Forms.DataGridView dataGridOrcamento;
        private MetroFramework.Controls.MetroTabPage PageCliente;
        private MetroFramework.Controls.MetroLabel lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private MetroFramework.Controls.MetroButton btnOrdemServico;
        private MetroFramework.Controls.MetroButton btnVisualizar;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAlterar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.TextBox textPesquisaCliente;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblProximo;
        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.ToolTip toolTipOrcamento;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}