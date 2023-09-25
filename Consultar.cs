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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Cajero; Integrated Security=True;");

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Visible = false;
            menu.Visible = true;
        }

        private void Consultar_Load(object sender, EventArgs e)
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
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = $"SELECT * from Cliente Where Cli_Cedula = '{cedula}'";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource
            {
                DataSource = table
            };
            DgvConsultar.DataSource = bSource;
        }
    }
}
