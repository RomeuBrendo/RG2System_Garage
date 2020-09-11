namespace RG2System_Garage.Shared.Formulario.Toast
{
    partial class frmToast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToast));
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.okay = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.White;
            this.lblMenssagem.Location = new System.Drawing.Point(78, 0);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(244, 66);
            this.lblMenssagem.TabIndex = 1;
            this.lblMenssagem.Text = "label1";
            this.lblMenssagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okay
            // 
            this.okay.Image = ((System.Drawing.Image)(resources.GetObject("okay.Image")));
            this.okay.Location = new System.Drawing.Point(0, 0);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(72, 66);
            this.okay.TabIndex = 4;
            // 
            // error
            // 
            this.error.Image = ((System.Drawing.Image)(resources.GetObject("error.Image")));
            this.error.Location = new System.Drawing.Point(0, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(72, 66);
            this.error.TabIndex = 5;
            // 
            // Info
            // 
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(72, 66);
            this.Info.TabIndex = 6;
            // 
            // TimerClose
            // 
            this.TimerClose.Interval = 3000;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // frmToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 67);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.error);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.lblMenssagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToast";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmToast";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmToast_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.Label okay;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Timer TimerClose;
    }
}