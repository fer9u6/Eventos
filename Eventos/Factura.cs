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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.Servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.Fill(this.eventosDataSet.Servicio);
            // TODO: This line of code loads data into the 'eventosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.eventosDataSet.Cliente);
            // TODO: This line of code loads data into the 'eventosDataSet.Evento' table. You can move, or remove it, as needed.
            this.eventoTableAdapter.Fill(this.eventosDataSet.Evento);
            // TODO: This line of code loads data into the 'eventosDataSet.Factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.eventosDataSet.Factura);

        }
    }
}
