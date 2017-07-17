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
    public partial class BuscarOrdenCompra : Form
    {

        OrdenCompra ordencompra;
        AccesoBaseDatos bd;


        public BuscarOrdenCompra()
        {
            InitializeComponent();
            ordencompra = new OrdenCompra();
            bd = new AccesoBaseDatos();
            cbOrden.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cargarTabla(dataGridView1, cbOrden.Text);
        }

        private void cargarTabla(DataGridView dgv, string idorden)
        {
            DataTable tabla = bd.ejecutarConsultaTabla("SELECT distinct a.idordencompra as Orden, b.idlineaorden as Linea, e.nombre as Proveedor, c.nombre as Servicio, c.costo as Costo, b.cantidad as Cantidad from ordencompra a, lineaorden b, servicio c, proveedor d, personajuridica e where a.idordencompra = b.idordencompra and b.idservicio = c.idservicio and c.idproveedor = d.Idproveedor and d.id = e.id and a.idordencompra = '" + idorden + "'");
            SqlDataReader sqlTotal = null;
            try
            {
                sqlTotal = bd.ejecutarConsulta("select oc.monto from  ordencompra oc where oc.idordencompra = '"+idorden+"'");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            string sTotal = "";
            while (sqlTotal.Read())
            {
                sTotal = sqlTotal[0].ToString();
            }
            tbTotal.Text = sTotal;
            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgv.DataSource = bs;
            //Ciclo para darle un ancho a cada columna del datagridview
            //proporcionado
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 50;
            for (int i = 2; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 100;
            }
        }

        private void cbEvento_Click(object sender, EventArgs e)
        {
            llenarComboboxEvento(cbEvento);
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

        private void llenarComboboxOrden(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ordencompra.obtenerIdOrdenes(cbEvento.Text);
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

        private void cbOrden_Click(object sender, EventArgs e)
        {
            llenarComboboxOrden(cbOrden);
        }



        private void cbEvento_TextUpdate(object sender, EventArgs e)
        {
            cbOrden.Enabled = true;
            button1.Enabled = true;
            cbOrden.Visible = true;
            button1.Visible = true;
            label3.Visible = true;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbOrden.Enabled = true;
            button1.Enabled = true;
            cbOrden.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
        }

        private void cbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.borrarOrden(cbOrden.Text);
        }

        private void borrarOrden(string idorden)
        {
            string delete = "delete from lineaorden where idordencompra = '"+idorden+"' ";
            bd.actualizarDatos(delete);
            delete = "delete from ordencompra where idordencompra = '" + idorden + "' ";
            bd.actualizarDatos(delete);
            tbTotal.Clear();
            dataGridView1.DataSource = null;
            cbOrden.Items.Clear();
        }

    }
}
