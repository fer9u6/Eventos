using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Eventos
{
    public partial class FacturaAPdf : Form
    {
        AccesoBaseDatos db;

        public FacturaAPdf()
        {
            db = new AccesoBaseDatos();
            InitializeComponent();
            llenarComboboxFactura(comboBoxIdFactura);
        }

        public SqlDataReader obtenerFacturas()
        {
            SqlDataReader datos = null;
            try
            {
                datos = db.ejecutarConsulta("select distinct IdFactura from Factura");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        private void llenarComboboxFactura(ComboBox combobox)
        {
            combobox.Items.Clear();
            //Se obtiene un dataReader con todos los nombres de los eventos de
            //la base de datos
            SqlDataReader datos = this.obtenerFacturas();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toPDF();
        }

        #region creacion-pdf

        private void toPDF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Factura";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();

                string comboBox = comboBoxIdFactura.Text;

                string idFactura = db.ejecutarConsultaValor("select IdFactura from Factura where IdFactura = '" + comboBox + "'");
                string idEvento = db.ejecutarConsultaValor("select IdEvento from Factura where IdFactura = '" + comboBox + "'");
                string idCliente = db.ejecutarConsultaValor("select IdCliente from Factura where IdFactura = '" + comboBox + "'");
                string fecha = db.ejecutarConsultaValor("select Fecha from Factura where IdFactura = '" + comboBox + "'");
                string monto = db.ejecutarConsultaValor("select Monto from Factura where IdFactura = '" + comboBox + "'");

                string idPersona = db.ejecutarConsultaValor("select Id from Cliente where IdCliente = '" + idCliente + "'");
                string nom1 = db.ejecutarConsultaValor("select Nombre from PersonaFisica where Id = '" + idPersona + "'");
                string ap1 = db.ejecutarConsultaValor("select Apellido1 from PersonaFisica where Id = '" + idPersona + "'");
                string ap2 = db.ejecutarConsultaValor("select Apellido2 from PersonaFisica where Id = '" + idPersona + "'");

                string nomCliente = nom1 + " " + ap1 + " " + ap2;
                string nomEvento = db.ejecutarConsultaValor("select Nombre from Evento where IdEvento = '" + idEvento + "'");
                

                DataTable lineaFactura = db.ejecutarConsultaTabla("select IdServicio, Cantidad from LineaFactura where IdFactura = '" + comboBox + "'");

                Chunk chunk = new Chunk("Factura EventosDB", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Id Factura = " + idFactura));
                doc.Add(new Paragraph("Cliente = " + nomCliente + " (Id: " + idCliente + ")"));
                doc.Add(new Paragraph("Evento a realizar = " + nomEvento + " (Id: " + idEvento + ")"));
                doc.Add(new Paragraph("Fecha de la factura = " + fecha));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Servicios por cobrar: "));
                for (int i = 0; i < lineaFactura.Rows.Count; i++)
                {
                    DataRow row = lineaFactura.Rows[i];
                    int f = 0;
                    foreach (object item in row.ItemArray)
                    {
                        if (f == 0) {
                            string nomServicio = db.ejecutarConsultaValor("select Nombre from Servicio where IdServicio = '" + item + "'");
                            doc.Add(new Paragraph("   -> " + nomServicio + " (Id: " + item + ")"));
                        } else if (f > 0) {
                            doc.Add(new Paragraph("   ----> Cantidad: " + item));
                        }
                        f++;
                    }
                }
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Monto a cobrar: " + monto));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));

                doc.AddCreationDate();
                doc.Close();
            }
        }

        #endregion
    }
}
