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
    public partial class EliminarServicios : Form
    {
        AgregarServicios ventana;

        Servicios_conexion servicio;
        public EliminarServicios(AgregarServicios param)
        {
            ventana = param;
            InitializeComponent();
            servicio = new Servicios_conexion();
        }

        public void cargar()
        {
            llenarCombobox(comboBox_nombre);
            llenarTabla(dataGridView_eliminar, null, null);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void linkLabel_agregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana.Show();
            this.Close();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            servicio.eliminarServicio(comboBox_nombre.Text);
            llenarCombobox(comboBox_nombre);
            llenarTabla(dataGridView_eliminar, null, null);
        }

        private void comboBox_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EliminarServicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
