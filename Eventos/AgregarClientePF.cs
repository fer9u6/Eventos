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
    public partial class AgregarClientePF : Form
    {
        Cliente cliente;
        public AgregarClientePF()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1guardar_Click(object sender, EventArgs e)
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

            genero.ToString();

            int resultado = cliente.agregarCliente(textBoxCed.Text, textBoxNom.Text, textBoxApe1.Text, textBoxApe2.Text, textBoxCorreo.Text, dateTimePicker1FecNac.Value.ToString("yyyy-MM-dd"), genero, textBoxidCliente.Text);


            //Si la inserción devuelve un 0 la inserción fue exitosa, por lo que se muestra un mensaje de éxito             
            if (resultado == 0)
            {
                MessageBox.Show("El cliente ha sido agregado exitosamente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Se limpian las cajas de texto para permitir al usuario añadir un nuevo estudiante cuando lo desee                                 
                textBoxNom.Clear();
                textBoxApe1.Clear();
                textBoxApe2.Clear();
                textBoxCorreo.Clear();
                textBoxCed.Clear();
                textBoxTel.Clear();
                textBoxidCliente.Clear();

            }             //si la inserción devuelve un código de error se puede validar con un mensaje de error personalizado             
            else if (resultado == 2627)
            {
                MessageBox.Show("Ya existe un cliente asociado a este numero de cedula en el sistema", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Menu ag = new Menu();
            ag.Show();
            this.Hide();
        }

        private void textBoxApe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void AgregarClientePF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AgregarClientePF_Load(object sender, EventArgs e)
        {

        }
    }
}

