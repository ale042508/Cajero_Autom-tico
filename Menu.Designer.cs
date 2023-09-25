namespace Cajero_Automatico
{
    partial class Menu
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
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SalirMenubtn = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDepositar.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepositar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDepositar.Location = new System.Drawing.Point(136, 215);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(139, 70);
            this.BtnDepositar.TabIndex = 1;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetirar.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnRetirar.Location = new System.Drawing.Point(318, 215);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(139, 70);
            this.BtnRetirar.TabIndex = 2;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnConsultar.Location = new System.Drawing.Point(502, 215);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(139, 70);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // SalirMenubtn
            // 
            this.SalirMenubtn.BackColor = System.Drawing.Color.LightBlue;
            this.SalirMenubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalirMenubtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirMenubtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SalirMenubtn.Location = new System.Drawing.Point(718, 405);
            this.SalirMenubtn.Name = "SalirMenubtn";
            this.SalirMenubtn.Size = new System.Drawing.Size(70, 33);
            this.SalirMenubtn.TabIndex = 4;
            this.SalirMenubtn.Text = "Volver";
            this.SalirMenubtn.UseVisualStyleBackColor = false;
            this.SalirMenubtn.Click += new System.EventHandler(this.SalirMenubtn_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(207, 30);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(388, 61);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Cajero Automático";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.SalirMenubtn);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.BtnDepositar);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button SalirMenubtn;
        private System.Windows.Forms.Label LblTitulo;
    }
}