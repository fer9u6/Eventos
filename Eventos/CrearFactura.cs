using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eventos
{
    public partial class CrearFactura : Form
    {
        AccesoBaseDatos db;
        Facturas facturas;

        List<string> serviciosIncluidos;
        List<int> cantidadServicios;

        public CrearFactura()
        {
            InitializeComponent();
            db = new AccesoBaseDatos();
            facturas = new Facturas();
            serviciosIncluidos = new List<string> ();
            cantidadServicios = new List<int> ();
            this.llenarComboboxServicio(comboBox_servicio);
            this.llenarComboboxCliente(comboBoxCliente);
            this.llenarComboboxEvento(comboBoxEvento);
        }

        public SqlDataReader obtenerCliente()
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("select distinct j.nombre from personaJuridica j, cliente c where j.id = c.id union select distinct f.nombre from personaFisica f, cliente c where f.id = c.id");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        public SqlDataReader obtenerEvento()
        {
            SqlDataReader datos = null;
            try
            {
                   datos = db.ejecutarConsulta("select distinct Evento.nombre from Evento");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        private void llenarComboboxEvento(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los eventos de
            //la base de datos
            SqlDataReader datos = this.obtenerEvento();
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

        private void llenarComboboxCliente(ComboBox combobox)
        {
            Servicios_conexion servicio = new Servicios_conexion();
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los clientes de
            //la base de datos
            SqlDataReader datos = this.obtenerCliente();
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
            Servicios_conexion servicio = new Servicios_conexion();
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los servicios de
            //la base de datos
            SqlDataReader datos = servicio.obtenerServicios();
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

        private void button2_Click(object sender, EventArgs e) //Crear factura y linea factura
        {
            facturas.agregarFactura(comboBoxEvento.Text, comboBoxCliente.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox1.Text);
            facturas.agregarLineaFactura(serviciosIncluidos, cantidadServicios);

            MessageBox.Show("La factura ha sido creada exitosamente.");
            comboBoxCliente.ResetText();
            comboBoxEvento.ResetText();
            dateTimePicker1.ResetText();
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Linea Factura
        {
            string servicio = comboBox_servicio.Text;
            int cantidad = (int)numericUpDown1.Value;

            serviciosIncluidos.Add(servicio);
            cantidadServicios.Add(cantidad);
            int monto = Int32.Parse(db.ejecutarConsultaValor("select Precio from Servicio where Nombre = '" + servicio + "'"));
            int resultado = monto*cantidad;
            if (Int32.TryParse(textBox1.Text, out int montoOg)) {
                resultado += montoOg;
            }
            textBox1.Text = resultado.ToString();

            comboBox_servicio.ResetText();
            numericUpDown1.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
