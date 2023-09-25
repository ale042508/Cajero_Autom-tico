using Cajero_Automatico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SalirMenubtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Visible = true;
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            Depositar depositar = new Depositar();
            this.Visible = false;
            depositar.Visible = true;
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            Retirar retirar = new Retirar();
            this.Visible = false;
            retirar.Visible = true;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            this.Visible = false;
            consultar.Visible = true;
        }
    }
}