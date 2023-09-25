namespace Cajero_Automatico
{
    partial class Depositar
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
            this.LblMontoDepositar = new System.Windows.Forms.Label();
            this.TxtMontoDepositar = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.CkbConfirmarDeposito = new System.Windows.Forms.CheckBox();
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMontoDepositar
            // 
            this.LblMontoDepositar.AutoSize = true;
            this.LblMontoDepositar.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoDepositar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblMontoDepositar.Location = new System.Drawing.Point(75, 82);
            this.LblMontoDepositar.Name = "LblMontoDepositar";
            this.LblMontoDepositar.Size = new System.Drawing.Size(152, 26);
            this.LblMontoDepositar.TabIndex = 2;
            this.LblMontoDepositar.Text = "Monto a Depositar";
            // 
            // TxtMontoDepositar
            // 
            this.TxtMontoDepositar.Location = new System.Drawing.Point(80, 120);
            this.TxtMontoDepositar.MaxLength = 5;
            this.TxtMontoDepositar.Name = "TxtMontoDepositar";
            this.TxtMontoDepositar.Size = new System.Drawing.Size(147, 20);
            this.TxtMontoDepositar.TabIndex = 1;
            this.TxtMontoDepositar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMontoDepositar_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(72, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(157, 44);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Depositar";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CkbConfirmarDeposito
            // 
            this.CkbConfirmarDeposito.AutoSize = true;
            this.CkbConfirmarDeposito.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CkbConfirmarDeposito.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CkbConfirmarDeposito.Location = new System.Drawing.Point(80, 168);
            this.CkbConfirmarDeposito.Name = "CkbConfirmarDeposito";
            this.CkbConfirmarDeposito.Size = new System.Drawing.Size(109, 30);
            this.CkbConfirmarDeposito.TabIndex = 2;
            this.CkbConfirmarDeposito.Text = "Confirmar";
            this.CkbConfirmarDeposito.UseVisualStyleBackColor = true;
            this.CkbConfirmarDeposito.CheckedChanged += new System.EventHandler(this.CkbConfirmarDeposito_CheckedChanged);
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepositar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDepositar.Location = new System.Drawing.Point(100, 229);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(109, 28);
            this.BtnDepositar.TabIndex = 3;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Visible = false;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVolver.Location = new System.Drawing.Point(248, 268);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(60, 26);
            this.BtnVolver.TabIndex = 7;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 306);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnDepositar);
            this.Controls.Add(this.CkbConfirmarDeposito);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtMontoDepositar);
            this.Controls.Add(this.LblMontoDepositar);
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMontoDepositar;
        private System.Windows.Forms.TextBox TxtMontoDepositar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.CheckBox CkbConfirmarDeposito;
        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.Button BtnVolver;
    }
}