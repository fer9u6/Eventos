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
    public partial class MenuSecretaria : Form
    {
        public MenuSecretaria()
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
            ConsultaEvento ce = new ConsultaEvento();
            ce.Show();
            this.Hide();
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
            ListaClientes l = new ListaClientes();
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

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarServicios v_agregar = new AgregarServicios(this);
            v_agregar.Show();
            this.Hide();
        }

        private void buscarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarServicios v_buscar = new BuscarServicios(new AgregarServicios(this));
            v_buscar.cargar();
            v_buscar.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eliminarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarServicios v_eliminar = new EliminarServicios(new AgregarServicios(this));
            v_eliminar.cargar();
            v_eliminar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
            this.Hide();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFactura cf = new CrearFactura();
            cf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
            this.Hide();
        }
    }
}
