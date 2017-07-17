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
    public partial class AgregarEmpleado : Form
    {
        Empleado empleado;
        Direccion dir;
        public AgregarEmpleado()
        {
            InitializeComponent();
            empleado = new Empleado();
            dir = new Direccion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1Guardar_Click(object sender, EventArgs e)
        {
            //obtengo el genero seleccionado en la pantalla             
            char genero = ' ';

            //El control radiobutton tiene la propiedad Checked en true si este se encuentra seleccionado             
            if (radioButton1F.Checked)
            {
                genero = 'F';
            }
            else if (radioButton2M.Checked)
            {
                genero = 'M';
            }

            /*Mediante el objeto de tipo Estudiante podemos agregar un nuevo estudiante con el método agregarEstudiante, el cual recibe por parámetro todos los valores de la tabla Estudiante*/
          
            int resultado = 1;
            if (textBoxCed.Text == "")
            {
                MessageBox.Show("Agrege numero de cedula ");
            }
            else
            {
                resultado = empleado.agregarEmpleado(textBoxCed.Text, textBoxNom.Text, textBoxApe1.Text, textBoxApe2.Text, textBoxCorreo.Text, dateTimePicker1FecNac.Value.ToString("yyyy-MM-dd"), genero, textBoxIdEmpleado.Text, textBoxEncargado.Text, textBoxSucursal.Text, textBoxTel.Text);
            }

            if (comboBoxPais.Text != "Seleccione" && comboBoxPro.Text != "Seleccione" && comboBoxCan.Text != "Seleccione")
            {
                string tipo = "casa";
                string codPais = dir.obtenerCodPais(comboBoxPais.Text);
                string codProvincia = dir.obtenerCodProvincia(comboBoxPro.Text);
                string codCanton = dir.obtenerCodCanton(comboBoxCan.Text);
                int resultadodir = dir.agregarDireccion(textBoxCed.Text, tipo, codPais, codProvincia, codCanton, textBoxDesc.Text);
            }

            //Si la inserción devuelve un 0 la inserción fue exitosa, por lo que se muestra un mensaje de éxito             
            if (resultado == 0)
            {
                MessageBox.Show("El empleado ha sido agregado exitosamente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Se limpian las cajas de texto para permitir al usuario añadir un nuevo estudiante cuando lo desee                                 
                textBoxNom.Clear();
                textBoxApe1.Clear();
                textBoxApe2.Clear();
                textBoxCorreo.Clear();
                textBoxCed.Clear();
                textBoxTel.Clear();
                textBoxSucursal.Clear();
                textBoxIdEmpleado.Clear();
                textBoxSucursal.Clear();
                textBoxEncargado.Clear();

            }             //si la inserción devuelve un código de error se puede validar con un mensaje de error personalizado             
            else if (resultado == 2627)
            {
                MessageBox.Show("Ya existe un cliente asociado a este numero de cedula en el sistema", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void llenarComboboxPais(ComboBox combobox)
        {             //Se obtiene un dataReader con todos los nombres de los empleados de la base de datos             
            SqlDataReader datos = dir.obtenerPaises();

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

            combobox.SelectedIndex = 0;

        }

        private void llenarComboboxProvincia(ComboBox combobox)
        {             //Se obtiene un dataReader con todos los nombres de los empleados de la base de datos             
            SqlDataReader datos = dir.obtenerProvincias();

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

            combobox.SelectedIndex = 0;

        }
        private void llenarComboboxCantones(ComboBox combobox)
        {  
                SqlDataReader datos = dir.obtenerCantones();
       
            if(comboBoxPro.Text !=null && comboBoxPro.Text != "Seleccione")
            {
                string codProvincia = dir.obtenerCodProvincia(comboBoxPro.Text);
                datos = dir.obtenerCantonesP(codProvincia);
            }


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

            combobox.SelectedIndex = 0;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu ag = new Menu();
            ag.Show();
            this.Hide();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

            llenarComboboxPais(comboBoxPais);
            llenarComboboxProvincia(comboBoxPro);
            llenarComboboxCantones(comboBoxCan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void AgregarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboboxCantones(comboBoxCan);
        }
    }
}
