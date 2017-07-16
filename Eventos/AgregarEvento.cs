using System;
using System.Windows.Forms;

namespace Eventos
{
    public partial class AgregarEvento : Form
    {
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
    }
}
