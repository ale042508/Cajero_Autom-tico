namespace Cajero_Automatico
{
    partial class Login
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblCedula = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLogin.Location = new System.Drawing.Point(129, 206);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(109, 28);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblCedula.Location = new System.Drawing.Point(42, 90);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(62, 26);
            this.LblCedula.TabIndex = 6;
            this.LblCedula.Text = "Cédula";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContrasena.Location = new System.Drawing.Point(51, 146);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(40, 26);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "PIN";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(134, 95);
            this.TxtCedula.MaxLength = 11;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(100, 20);
            this.TxtCedula.TabIndex = 1;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(134, 149);
            this.TxtContrasena.MaxLength = 4;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(100, 20);
            this.TxtContrasena.TabIndex = 2;
            this.TxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "Login\r\n";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSalir.Location = new System.Drawing.Point(266, 263);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(60, 26);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(338, 301);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.BtnLogin);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalir;
    }
}