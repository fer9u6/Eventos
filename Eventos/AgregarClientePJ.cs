﻿using System;
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
    public partial class AgregarClientePJ : Form
    {
        Cliente cliente;
        public AgregarClientePJ()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int resultado = 1;
            if (ced.Text == "")
            {
                MessageBox.Show("Agrege numero de cedula ");
            }
            else
            {
                string idcliente = cliente.obtenerNuevoId();
                resultado = cliente.agregarClientePJuridica(ced.Text, nom.Text, cor.Text, con.Text, idcliente);
            }
            //Si la inserción devuelve un 0 la inserción fue exitosa, por lo que se muestra un mensaje de éxito             
            if (resultado == 0)
            {
                MessageBox.Show("El cliente ha sido agregado exitosamente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Se limpian las cajas de texto para permitir al usuario añadir un nuevo estudiante cuando lo desee                                 
                nom.Clear();
                cor.Clear();
                ced.Clear();
                con.Clear();
                

            }             //si la inserción devuelve un código de error se puede validar con un mensaje de error personalizado             
            else if (resultado == 2627)
            {
                MessageBox.Show("Ya existe un cliente asociado a este numero de cedula en el sistema", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu ag = new Menu();
            ag.Show();
            this.Hide();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void AgregarClientePJ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AgregarClientePJ_Load(object sender, EventArgs e)
        {

        }
    }
}
