namespace RG2System_Garage.Viwer.Formulario.Configuracao
{
    partial class frmDadosEmpresa
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
            this.lblNomeFantasia = new MetroFramework.Controls.MetroLabel();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRacaoSocial = new MetroFramework.Controls.MetroLabel();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new MetroFramework.Controls.MetroLabel();
            this.txtFixo = new System.Windows.Forms.TextBox();
            this.lblFixo = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new MetroFramework.Controls.MetroLabel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.panel = new System.Windows.Forms.Panel();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(31, 55);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(99, 19);
            this.lblNomeFantasia.TabIndex = 8;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(138, 99);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(362, 20);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFantasia_KeyDown);
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtRazaoSocial.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // lblRacaoSocial
            // 
            this.lblRacaoSocial.AutoSize = true;
            this.lblRacaoSocial.Location = new System.Drawing.Point(46, 99);
            this.lblRacaoSocial.Name = "lblRacaoSocial";
            this.lblRacaoSocial.Size = new System.Drawing.Size(86, 19);
            this.lblRacaoSocial.TabIndex = 9;
            this.lblRacaoSocial.Text = "Razão Social:";
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Location = new System.Drawing.Point(138, 187);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 3;
            this.txtCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFantasia_KeyDown);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtCelular.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(76, 188);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 19);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular:";
            // 
            // txtFixo
            // 
            this.txtFixo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFixo.Location = new System.Drawing.Point(317, 187);
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(87, 20);
            this.txtFixo.TabIndex = 4;
            this.txtFixo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFantasia_KeyDown);
            this.txtFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtFixo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // lblFixo
            // 
            this.lblFixo.AutoSize = true;
            this.lblFixo.Location = new System.Drawing.Point(275, 188);
            this.lblFixo.Name = "lblFixo";
            this.lblFixo.Size = new System.Drawing.Size(36, 19);
            this.lblFixo.TabIndex = 13;
            this.lblFixo.Text = "Fixo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(86, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(138, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFantasia_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtEmail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(65, 231);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 19);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(138, 231);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(362, 84);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndereco_KeyDown);
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtEndereco.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(152, 359);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar (F4)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblFixo);
            this.panel.Controls.Add(this.btnCancelar);
            this.panel.Controls.Add(this.lblRacaoSocial);
            this.panel.Controls.Add(this.lblEmail);
            this.panel.Controls.Add(this.lblEndereco);
            this.panel.Controls.Add(this.lblCelular);
            this.panel.Controls.Add(this.txtNomeFantasia);
            this.panel.Controls.Add(this.btnSalvar);
            this.panel.Controls.Add(this.lblNomeFantasia);
            this.panel.Controls.Add(this.txtRazaoSocial);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtEndereco);
            this.panel.Controls.Add(this.txtFixo);
            this.panel.Controls.Add(this.txtCelular);
            this.panel.Location = new System.Drawing.Point(20, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(532, 425);
            this.panel.TabIndex = 0;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(138, 55);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(362, 20);
            this.txtNomeFantasia.TabIndex = 0;
            this.txtNomeFantasia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFantasia_KeyDown);
            this.txtNomeFantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFantasia_KeyPress);
            this.txtNomeFantasia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            // 
            // frmDadosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(572, 505);
            this.Controls.Add(this.panel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadosEmpresa";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dados da Empresa";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Shown += new System.EventHandler(this.frmDadosEmpresa_Shown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDadosEmpresa_PreviewKeyDown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private MetroFramework.Controls.MetroLabel lblRacaoSocial;
        private System.Windows.Forms.TextBox txtCelular;
        private MetroFramework.Controls.MetroLabel lblCelular;
        private System.Windows.Forms.TextBox txtFixo;
        private MetroFramework.Controls.MetroLabel lblFixo;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtNomeFantasia;
    }
}