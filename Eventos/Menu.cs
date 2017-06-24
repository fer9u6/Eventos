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
    }
}
