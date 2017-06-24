using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarClientePF pf = new AgregarClientePF();
            pf.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarClientePJ pj = new AgregarClientePJ();
            pj.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListaEmpleados l = new ListaEmpleados();
            l.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListaClientesForm lc = new ListaClientesForm();
            lc.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarEmpleado ae = new AgregarEmpleado();
            ae.Show();
            this.Hide();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
