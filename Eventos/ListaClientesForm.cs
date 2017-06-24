using System;
using System.Data.SqlClient;
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
    public partial class ListaClientesForm : Form
    {
        Cliente cliente;
        public ListaClientesForm()
        {
            InitializeComponent();
            cliente = new Cliente();
        }


        /*Método para llenar un combobox con datos específicos          
         * Recibe: Un objeto combobox que va a llenar con una consulta específica          
         * Modifica: Llena el combobox que recibe por parámetro con el nombre de todos los clientes que se encuentran en la bd          
         * Retorna: Ningún valor*/
        private void llenarCombobox(ComboBox combobox)
        {             //Se obtiene un dataReader con todos los nombres de los clientes de la base de datos             
            SqlDataReader datos = cliente.obtenerListaNombresClientes();

            /*Si existen datos en la base de datos se carga como primer elemento del combobox un dato "Seleccione"  y luego se cargan todos los datos de la base de datos*/
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }             /*Si no hay tuplas en la base de datos se limpia el combobox y se carga unicamente el valor "Seleccione"*/
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }

            //Se pone por defecto la primera entrada del combobox seleccionada             
            combobox.SelectedIndex = 0;

        }


        /*Método para llenar un datagridview con datos específicos          
         * Recibe: Un control datagridview que va a cargar con datos, una string en caso que se quiera filtrar por el valor          
         ** del combobox y un string de filtroGeneral en caso que se quiera filtrar por el texto introducido por el usuario          
         * Modifica: carga los datos en el datagridview          
         * Retorna: ningún valor*/
        private void llenarTabla(DataGridView dataGridView, string filtroCombobox, string filtroGeneral)
        {
            /*obtiene un dataTable con todos los clientes que se encuentran en la base de datos que cumplan las condiciones  de los dos filtros que el método recibe por parámetro*/
            DataTable tabla = cliente.obtenerClientes(filtroCombobox, filtroGeneral);

            //Se inicializa el source para cargar el datagridview y se le asigna el dataTable obtenido             
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            //Ciclo para darle un ancho a cada columna del datagridview proporcionado             
            for (int i = 0; i < dataGridViewClientes.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaClientesForm_Load(object sender, EventArgs e)
        {
            //Llena el combobox de nombres de estudiante             
            llenarCombobox(comboBoxApe);
            //Llena el datagridview de estudiantes con todas las tuplas de cliente de la interfaz             
            llenarTabla(dataGridViewClientes, null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llena el datagridview con los estudiantes que contengan en alguno de sus campos el texto del textbox txtBuscar             
            llenarTabla(dataGridViewClientes, null, textBoxCed.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCliente ag = new AgregarCliente();
            ag.Show();
            this.Hide();
        }
    }
}
