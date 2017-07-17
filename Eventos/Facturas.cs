using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Eventos
{
    class Facturas
    {
        AccesoBaseDatos db;
        int idFactura;

        public Facturas()
        {
            db = new AccesoBaseDatos();
            idFactura = 0;
        }

        public int agregarFactura(string nomEvento, string nomCliente, string fecha, string monto)
        {
            string idEvento = obtenerIdEvento(nomEvento);
            string idCliente = obtenerIdCliente(nomCliente);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=10.1.4.119;Initial Catalog=eventos;Integrated Security=False;User ID=B41441;Password=b41441;Connect Timeout=45;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Factura ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            idFactura = dt.Rows.Count + 1;
            return db.actualizarDatos("insert into Factura (IdFactura, IdEvento, IdCliente, Fecha, Monto) VALUES('" + idFactura + "', '" + idEvento + "', '" + idCliente + "', '" + fecha + "', '" + monto + "')");
        }

        public void agregarLineaFactura(List<string> servicios, List<int> cantidades)
        {
            for (int i = 0; i < servicios.Count; i++)
            {
                string nomServicio = servicios[i];
                string idServicio = obtenerIdServicio(nomServicio);
                int cantidad = cantidades[i];
                int idLineaFactura = calcularIdLineaFactura();
                db.actualizarDatos("insert into LineaFactura(IdFactura, IdLineaFactura, IdServicio, Cantidad) values('" + idFactura + "', '" + idLineaFactura + "','" + idServicio + "','" + cantidad + "')");
            }
        }

        private string obtenerIdEvento(string nomEvento)
        {
            string evento = db.ejecutarConsultaValor("select idEvento from Evento where Nombre = '" + nomEvento + "'");
            return evento;
        }

        private string obtenerIdCliente(string nomCliente)
        {
            string id = db.ejecutarConsultaValor("select Id from PersonaFisica where Nombre = '" + nomCliente + "'");
            string cliente = db.ejecutarConsultaValor("select IdCliente from Cliente where Id = '" + id + "'");
            return cliente;
        }

        private string obtenerIdServicio(string nomServicio)
        {
            string servicio = db.ejecutarConsultaValor("select idServicio from Servicio where Nombre = '" + nomServicio + "'");
            return servicio;
        }

        private int calcularIdLineaFactura()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=10.1.4.119;Initial Catalog=eventos;Integrated Security=False;User ID=B41441;Password=b41441;Connect Timeout=45;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LineaFactura ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int idLineaFactura = dt.Rows.Count + 1;
            return idLineaFactura;
        }
    }
}
