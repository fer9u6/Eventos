using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Eventos
{
    public partial class Login : Form
    {
        LoginHandler lh;

        public Login()
        {
            InitializeComponent();
            lh = new LoginHandler();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = lh.checkPassword(textBox1.Text, textBox2.Text);
            if(resultado == 0)
            {
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearNuevoUsuario cu = new CrearNuevoUsuario();
            cu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int resultado = lh.checkPassword(textBox1.Text, textBox2.Text);
                if (resultado == 0)
                {
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
