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
    public partial class BuscarServicios : Form
    {
        AgregarServicios ventana;

        Servicios_conexion servicio;

        public BuscarServicios(AgregarServicios ventana_param)
        {
            ventana = ventana_param;
            InitializeComponent();
            servicio = new Servicios_conexion();
        }

        private void label_tuplas_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////////////
            llenarTabla(dataGridView_buscar, comboBox_nombre.Text, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_filtro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_filtro_Click(object sender, EventArgs e)
        {

        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_servicios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana.Show();
            this.Close();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            llenarTabla(dataGridView_buscar, comboBox_nombre.Text, textBox_filtro.Text);
        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se carga el datagridview con estudiantes que tengan como nombre el
            //seleccionado en el combobox nombre
            llenarTabla(dataGridView_buscar, comboBox_nombre.Text, null);
        }


        public void cargar()
        {
            llenarCombobox(comboBox_nombre);
            llenarTabla(dataGridView_buscar, null, null);
        }

        private void llenarTabla(DataGridView dataGridView, string filtroCombobox,
        string filtroGeneral)
        {
            /*obtiene un dataTable con todos los estudiantes que se encuentran en la
            base de datos que cumplan las condiciones
            de los dos filtros que el método recibe por parámetro*/
            DataTable tabla = servicio.obtenerTabla(filtroCombobox,
            filtroGeneral);
            //Se inicializa el source para cargar el datagridview y se le asigna el
            //dataTable obtenido
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
            ;
            dataGridView.DataSource = bindingSource;
            //Ciclo para darle un ancho a cada columna del datagridview
            //proporcionado
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void llenarCombobox(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void BuscarServicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
