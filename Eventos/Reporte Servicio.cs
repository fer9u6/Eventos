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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace Eventos
{
    public partial class Reporte_Servicio : Form
    {
        public Reporte_Servicio()
        {
            InitializeComponent();
            this.llenarTabla(dataGridView_servicios);
        }

        private void button_inicio_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }

        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridView_servicios.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridView_servicios);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView_servicios.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView_servicios.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView_servicios.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView_servicios.Columns.Count; j++)
                {
                    if (dataGridView_servicios[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView_servicios[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private void To_pdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
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
                string remito = "Eventos";
                string envio = "Fecha:" + DateTime.Now.ToString();
                string descripcion = "Servicios más contratados";

                Chunk chunk = new Chunk("Reporte Servicios", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(descripcion));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Close();

            }

        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            To_pdf();
        }

        



        private void llenarTabla(DataGridView dataGridView)
        {
            /*obtiene un dataTable con todos los estudiantes que se encuentran en la
            base de datos que cumplan las condiciones
            de los dos filtros que el método recibe por parámetro*/
            AccesoBaseDatos bd = new AccesoBaseDatos();
            DataTable tabla = bd.ejecutarConsultaTabla("with tabla as (select servicio.nombre, f.cantidad, row_number() over(order by cantidad desc) as num from lineafactura f, servicio where f.idservicio = servicio.idservicio) select* from tabla where num between 1 and 5");
            //Se inicializa el source para cargar el datagridview y se le asigna el
            //dataTable obtenido
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
            ;
            dataGridView.DataSource = bindingSource;
            //Ciclo para darle un ancho a cada columna del datagridview
            //proporcionado
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
