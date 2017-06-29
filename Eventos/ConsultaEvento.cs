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
    public partial class ConsultaEvento : Form
    {
        public ConsultaEvento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaEvento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.Evento' table. You can move, or remove it, as needed.
            this.eventoTableAdapter.Fill(this.eventosDataSet.Evento);

        }

        private void eventosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.Eventos(this.eventosDataSet.Evento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void ConsultaEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
