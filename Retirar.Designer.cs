namespace Cajero_Automatico
{
    partial class Retirar
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
            this.LblMontoRetirar = new System.Windows.Forms.Label();
            this.TxtMontoRetirar = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.CkbConfirmarRetiro = new System.Windows.Forms.CheckBox();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMontoRetirar
            // 
            this.LblMontoRetirar.AutoSize = true;
            this.LblMontoRetirar.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoRetirar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblMontoRetirar.Location = new System.Drawing.Point(75, 82);
            this.LblMontoRetirar.Name = "LblMontoRetirar";
            this.LblMontoRetirar.Size = new System.Drawing.Size(135, 26);
            this.LblMontoRetirar.TabIndex = 2;
            this.LblMontoRetirar.Text = "Monto a Retirar";
            // 
            // TxtMontoRetirar
            // 
            this.TxtMontoRetirar.Location = new System.Drawing.Point(80, 120);
            this.TxtMontoRetirar.MaxLength = 5;
            this.TxtMontoRetirar.Name = "TxtMontoRetirar";
            this.TxtMontoRetirar.Size = new System.Drawing.Size(147, 20);
            this.TxtMontoRetirar.TabIndex = 1;
            this.TxtMontoRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoRetirar_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(81, 18);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(128, 44);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Retirar";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CkbConfirmarRetiro
            // 
            this.CkbConfirmarRetiro.AutoSize = true;
            this.CkbConfirmarRetiro.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CkbConfirmarRetiro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CkbConfirmarRetiro.Location = new System.Drawing.Point(80, 168);
            this.CkbConfirmarRetiro.Name = "CkbConfirmarRetiro";
            this.CkbConfirmarRetiro.Size = new System.Drawing.Size(109, 30);
            this.CkbConfirmarRetiro.TabIndex = 2;
            this.CkbConfirmarRetiro.Text = "Confirmar";
            this.CkbConfirmarRetiro.UseVisualStyleBackColor = true;
            this.CkbConfirmarRetiro.CheckedChanged += new System.EventHandler(this.CkbConfirmarRetiro_CheckedChanged);
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRetirar.Location = new System.Drawing.Point(100, 229);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(109, 28);
            this.BtnRetirar.TabIndex = 3;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Visible = false;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVolver.Location = new System.Drawing.Point(248, 268);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(60, 26);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 306);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.CkbConfirmarRetiro);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtMontoRetirar);
            this.Controls.Add(this.LblMontoRetirar);
            this.Name = "Retirar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMontoRetirar;
        private System.Windows.Forms.TextBox TxtMontoRetirar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.CheckBox CkbConfirmarRetiro;
        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Button BtnVolver;
    }
}