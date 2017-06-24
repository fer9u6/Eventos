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
    public partial class AgregarServicios : Form
    {
        Servicios_conexion servicio;
        public AgregarServicios()
        {
            InitializeComponent();
            servicio = new Servicios_conexion();
        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_buscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscarServicios v_buscar = new BuscarServicios(this);
            v_buscar.cargar();
            v_buscar.Show();
            this.Hide();
        }

        private void linkLabel_eliminar_servicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarServicios v_buscar = new EliminarServicios(this);
            v_buscar.cargar();
            v_buscar.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            servicio.agregarServicio(comboBox_prov.Text, textBox_nombre.Text, textBox_detalle.Text, int.Parse(textBox_precio.Text), int.Parse(textBox_costo.Text));
            textBox_nombre.Text = "";
            textBox_detalle.Text = "";
            textBox_precio.Text = "";
            textBox_costo.Text = "";
        }



        private void llenarCombobox(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = servicio.obtenerProveedores();
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

        private void comboBox_prov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_prov_Click(object sender, EventArgs e)
        {
            llenarCombobox(comboBox_prov);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
