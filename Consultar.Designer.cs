namespace Cajero_Automatico
{
    partial class Consultar
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvConsultar = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.cliente_Consultar = new Cajero_Automatico.Cliente_Consultar();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Cajero_Automatico.Cliente_ConsultarTableAdapters.ClienteTableAdapter();
            this.cliNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliSaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(96, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(161, 44);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Consultar";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DgvConsultar
            // 
            this.DgvConsultar.AutoGenerateColumns = false;
            this.DgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliNombresDataGridViewTextBoxColumn,
            this.cliApellidosDataGridViewTextBoxColumn,
            this.cliSaldoDataGridViewTextBoxColumn});
            this.DgvConsultar.DataSource = this.clienteBindingSource;
            this.DgvConsultar.Location = new System.Drawing.Point(12, 56);
            this.DgvConsultar.Name = "DgvConsultar";
            this.DgvConsultar.Size = new System.Drawing.Size(340, 190);
            this.DgvConsultar.TabIndex = 7;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVolver.Location = new System.Drawing.Point(139, 274);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(79, 33);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // cliente_Consultar
            // 
            this.cliente_Consultar.DataSetName = "Cliente_Consultar";
            this.cliente_Consultar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.cliente_Consultar;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cliNombresDataGridViewTextBoxColumn
            // 
            this.cliNombresDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombres";
            this.cliNombresDataGridViewTextBoxColumn.HeaderText = "Nombre(s)";
            this.cliNombresDataGridViewTextBoxColumn.Name = "cliNombresDataGridViewTextBoxColumn";
            // 
            // cliApellidosDataGridViewTextBoxColumn
            // 
            this.cliApellidosDataGridViewTextBoxColumn.DataPropertyName = "Cli_Apellidos";
            this.cliApellidosDataGridViewTextBoxColumn.HeaderText = "Apellido(s)";
            this.cliApellidosDataGridViewTextBoxColumn.Name = "cliApellidosDataGridViewTextBoxColumn";
            // 
            // cliSaldoDataGridViewTextBoxColumn
            // 
            this.cliSaldoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Saldo";
            this.cliSaldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.cliSaldoDataGridViewTextBoxColumn.Name = "cliSaldoDataGridViewTextBoxColumn";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 330);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.DgvConsultar);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvConsultar;
        private System.Windows.Forms.Button BtnVolver;
        private Cliente_Consultar cliente_Consultar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Cliente_ConsultarTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliSaldoDataGridViewTextBoxColumn;
    }
}