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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void agregarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEvento ae = new AgregarEvento();
            ae.Show();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void buscarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void personaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarClientePJ pj = new AgregarClientePJ();
            pj.Show();
            this.Hide();
        }

        private void personaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarClientePF pf = new AgregarClientePF();
            pf.Show();
            this.Hide();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientesForm l = new ListaClientesForm();
            l.Show();
            this.Hide();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado ag = new AgregarEmpleado();
            ag.Show();
            this.Hide();
        }

        private void listaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEmpleados l = new ListaEmpleados();
            l.Show();
            this.Hide();
        }
    }
}
