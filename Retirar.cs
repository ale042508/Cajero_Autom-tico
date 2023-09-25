using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class Retirar : Form
    {
        public Retirar()
        {
            InitializeComponent();
        }
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Cajero; Integrated Security=True;");
        private void TxtMontoRetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMontoRetirar.Text != "" && Convert.ToDecimal(TxtMontoRetirar.Text) % 50 == 0)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string queryCedula = "Select Temp_Cedula From Temp Where Temp_ID = (Select max(Temp_ID) From Temp)";
                    SqlCommand commandCedula = new SqlCommand(queryCedula, conn);
                    SqlDataReader reader = commandCedula.ExecuteReader();
                    string cedula = "";
                    while (reader.Read())
                    {
                        cedula = reader.GetString(0);
                    }
                    conn.Close();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string querySuma = $"Select Cli_Saldo From Cliente Where Cli_Cedula = '{cedula}'";
                    SqlCommand commandSuma = new SqlCommand(querySuma, conn);
                    SqlDataReader readerSuma = commandSuma.ExecuteReader();
                    string saldoAntes = "";
                    decimal saldoDespues = 0;
                    while (readerSuma.Read())
                    {
                        saldoAntes = readerSuma.GetDecimal(0).ToString();
                    }
                    if (Convert.ToDecimal(saldoAntes) >= Convert.ToDecimal(TxtMontoRetirar.Text))
                    {
                        saldoDespues = Convert.ToDecimal(saldoAntes) - Convert.ToDecimal(TxtMontoRetirar.Text);
                        conn.Close();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string querySaldo = $"Update Cliente Set Cli_Saldo = @Cli_Saldo Where Cli_Cedula = '{cedula}'";
                        SqlCommand commandSaldo = new SqlCommand(querySaldo, conn);
                        commandSaldo.Parameters.AddWithValue("@Cli_Saldo", Math.Round(saldoDespues, 0));
                        if (commandSaldo.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Monto retirado");
                            Menu menu = new Menu();
                            this.Visible = false;
                            menu.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Monto a retirar incorrecto\n\nIntente otro monto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene saldo suficiente para retirar!");
                    }
                }
                else
                {
                    if (Convert.ToDecimal(TxtMontoRetirar.Text) % 50 != 0)
                    {
                        MessageBox.Show("Solo billetes de:\n\n$50, $100, $200, $500, $1000, $2000!");
                    }
                    else
                    {
                        MessageBox.Show("Digite un monto!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CkbConfirmarRetiro_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbConfirmarRetiro.Checked == true)
            {
                BtnRetirar.Visible = true;
            }
            else
            {
                BtnRetirar.Visible = false;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Visible = false;
            menu.Visible = true;
        }
    }
}
