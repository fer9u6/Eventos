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
        AccesoBaseDatos db;

        public Factura()
        {
            InitializeComponent();
            db = new AccesoBaseDatos();
            this.cargarTabla(dataGridView1, 1);
            this.cargarTabla(dataGridView2, 2);
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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarTabla(DataGridView dgv, int tipo)
        {
            DataTable tabla = new DataTable();
            if (tipo == 1) {
                tabla = db.ejecutarConsultaTabla("Select f.IdFactura, f.IdEvento, e.Nombre 'Nombre Evento', f.IdCliente, pf.Nombre 'Nombre Cliente', f.Fecha, f.Monto from Factura f, Evento e, Cliente c, PersonaFisica pf where f.IdEvento = e.IdEvento AND f.IdCliente = c.IdCliente AND pf.Id = c.Id order by f.IdFactura ASC");
            } else if (tipo == 2) {
                tabla = db.ejecutarConsultaTabla("Select lf.IdFactura, lf.IdLineaFactura, lf.IdServicio, s.Nombre 'Nombre Servicio', lf.Cantidad from LineaFactura lf, Servicio s where lf.IdServicio = s.IdServicio");
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgv.DataSource = bindingSource;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 100;
            }
        }
    }
}
