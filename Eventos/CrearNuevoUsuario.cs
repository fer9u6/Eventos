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
    public partial class CrearNuevoUsuario : Form
    {
        public CrearNuevoUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario au = new AgregarUsuario();
            int resultado = au.agregarUsuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if(resultado == 0)
            {
                MessageBox.Show("El usuario ha sido agregado exitosamente.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Error a la hora de agregar usuario.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void CrearNuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CrearNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
