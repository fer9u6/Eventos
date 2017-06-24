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
    public partial class AgregarEmpleado : Form
    {
        Empleado empleado;
        public AgregarEmpleado()
        {
            InitializeComponent();
            empleado = new Empleado();
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
            int resultado = empleado.agregarEmpleado(textBoxCed.Text, textBoxNom.Text, textBoxApe1.Text, textBoxApe2.Text, textBoxCorreo.Text, dateTimePicker1FecNac.Value.ToString("yyyy-MM-dd"), genero, textBoxIdEmpleado.Text, textBoxEncargado.Text, textBoxSucursal.Text);

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
                textBoxDir.Clear();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarCliente ag = new AgregarCliente();
            ag.Show();
            this.Hide();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
