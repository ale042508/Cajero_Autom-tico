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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Cajero; Integrated Security=True;");

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string queryNo = $"Select Cli_Estatus From Cliente Where Cli_Cedula = '{TxtCedula.Text}'";
                SqlCommand commandNo = new SqlCommand(queryNo, conn)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader readerNo = commandNo.ExecuteReader();
                string no = "";
                while (readerNo.Read())
                {
                    no = readerNo.GetString(0);
                }
                if (no == "A")
                {
                    conn.Close();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string query = "SELECT COUNT(1) FROM Cliente WHERE Cli_Cedula = @Cli_Cedula AND Cli_Clave = @Cli_Clave";
                    SqlCommand Command = new SqlCommand(query, conn)
                    {
                        CommandType = CommandType.Text
                    };
                    Command.Parameters.AddWithValue("@Cli_Cedula", TxtCedula.Text);
                    Command.Parameters.AddWithValue("@Cli_Clave", TxtContrasena.Text);
                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    if (count == 1)
                    {
                        conn.Close();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string insert = $"Insert Into Temp (Temp_Cedula) Values ('{TxtCedula.Text}')";
                        SqlCommand command = new SqlCommand(insert, conn);
                        command.ExecuteNonQuery();
                        Menu menu = new Menu();
                        this.Visible = false;
                        menu.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecto.");
                    }
                }
                else
                {
                    if (no == "I")
                    {
                        MessageBox.Show("\t\tUsuario bloqueado\n\nContactarse con un supervisor");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto.");
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = $"Delete From Temp";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Application.Exit();
        }
    }
}