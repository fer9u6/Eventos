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

namespace Eventos
{
    public partial class AgregarOrdenCompra : Form
    {
        AccesoBaseDatos bd;
        OrdenCompra ordencompra;
        Menu menu;
        string IdOrden;
        int IdLineaOrden;
        int total;

        public AgregarOrdenCompra(Menu param)
        {
            bd = new AccesoBaseDatos();
            menu = param;
            InitializeComponent();
            ordencompra = new OrdenCompra();
            IdOrden = "";
            IdLineaOrden = 1;
            total = 0;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            cbServicio.Visible = false;
            tbCosto.Visible = false;
            tbCantidad.Visible = false;
            btnAgregarServicio.Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            llenarComboboxEvento(ComboBox1);
        }

        private void llenarComboboxEvento(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ordencompra.obtenerEventos();
            /*Si existen datos en la base de datos se carga como primer elemento del
            combobox un dato "Seleccione"
            y luego se cargan todos los datos de la base de datos*/
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            /*Si no hay tuplas en la base de datos se limpia el combobox y se carga
            unicamente el valor "Seleccione"*/
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            //Se pone por defecto la primera entrada del combobox seleccionada
            combobox.SelectedIndex = 0;
        }

        private void llenarComboboxProveedor(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ordencompra.obtenerProveedores();
            /*Si existen datos en la base de datos se carga como primer elemento del
            combobox un dato "Seleccione"
            y luego se cargan todos los datos de la base de datos*/
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            /*Si no hay tuplas en la base de datos se limpia el combobox y se carga
            unicamente el valor "Seleccione"*/
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            //Se pone por defecto la primera entrada del combobox seleccionada
            combobox.SelectedIndex = 0;
        }

        private void llenarComboboxServicio(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ordencompra.obtenerServicios(cbProveedor.Text);
            /*Si existen datos en la base de datos se carga como primer elemento del
            combobox un dato "Seleccione"
            y luego se cargan todos los datos de la base de datos*/
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }

            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            //Se pone por defecto la primera entrada del combobox seleccionada
            combobox.SelectedIndex = 0;
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CcbProveedor_Click(object sender, EventArgs e)
        {
            llenarComboboxProveedor(cbProveedor);
        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = bd.ejecutarConsulta("select max(cast(idOrdenCompra as int)) FROM OrdenCompra");
            int nextId = 0;
            while (reader.Read())
            {
                nextId = reader.GetInt32(0);
            }
            nextId++;
            IdOrden = nextId.ToString();
            ordencompra.agregarOrdenCompra(IdOrden, ComboBox1.Text, cbProveedor.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            cbServicio.Visible = true;
            tbCosto.Visible = true;
            tbCantidad.Visible = true;
            btnAgregarServicio.Visible = true;
            IdOrden = nextId.ToString();
            textBox1.Text = IdOrden;

            ComboBox1.Enabled = false;
            cbProveedor.Enabled = false;
            dateTimePicker1.Enabled = false;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbServicio_Click(object sender, EventArgs e)
        {
            llenarComboboxServicio(cbServicio);
        }

        private void llenarCosto(object sender, EventArgs e)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select costo from servicio where nombre= '" + cbServicio.Text + "';");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            while (datos.Read())
            {
                tbCosto.Text = datos["costo"].ToString();
            }
           // tbCosto.Refresh();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            ordencompra.agregarLineaOrden(IdOrden, IdLineaOrden.ToString(), cbServicio.Text, int.Parse(tbCantidad.Text));
            IdLineaOrden++;
            total += int.Parse(tbCosto.Text) * int.Parse(tbCantidad.Text);
            tbMonto.Text = total.ToString();
            cbServicio.Items.Clear();
            tbCosto.Clear();
            tbCantidad.Clear();
            string update = "update OrdenCompra set monto="+total+"where idordencompra = '"+IdOrden+"'";
            bd.actualizarDatos(update);
            
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            ordencompra = new OrdenCompra();
            IdOrden = "";
            IdLineaOrden = 1;
            total = 0;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            cbServicio.Visible = false;
            tbCosto.Visible = false;
            tbCantidad.Visible = false;
            btnAgregarServicio.Visible = false;

            tbMonto.Clear();
            ComboBox1.Items.Clear();
            cbProveedor.Items.Clear();
            dateTimePicker1.ResetText();


            ComboBox1.Enabled = true;
            cbProveedor.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void ComboBox1_Validated(object sender, EventArgs e)
        {

        }
    }
}
