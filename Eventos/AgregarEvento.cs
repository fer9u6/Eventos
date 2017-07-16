using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eventos
{
    public partial class AgregarEvento : Form

    {
        AgregaEvento ae = new AgregaEvento();

        public AgregarEvento()
        {
            InitializeComponent();
        }

        private void Evento_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregaEvento ae = new AgregaEvento();
            int resultado = ae.agregarEvento(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox4.Text, textBox5.Text, Int32.Parse(textBox11.Text), Int32.Parse(textBox10.Text), Int32.Parse(textBox7.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), Int32.Parse(textBox8.Text), textBox9.Text);

            if (resultado == 0)
            {
                MessageBox.Show("El evento ha sido agregado exitosamente.");
                textBox1.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
            }
            else
            {
                MessageBox.Show("Error a la hora de agregar usuario.");
                Console.WriteLine(resultado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void AgregarEvento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void llenarCombobox1(ComboBox combobox) {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ae.obtenerEmpleados();
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

        private void llenarCombobox2(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los estudiantes de
            //la base de datos
            SqlDataReader datos = ae.obtenerClientes();
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
            llenarCombobox1(comboBox1);
        }

        private void comboBox2_Click_1(object sender, EventArgs e)
        {
            llenarCombobox2(comboBox2);
        }
    }
}
