using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    class OrdenCompra
    {
        AccesoBaseDatos bd;

        public OrdenCompra()
        {
            bd = new AccesoBaseDatos();

        }

        public SqlDataReader obtenerEventos()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select distinct nombre from evento;");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }


        public SqlDataReader obtenerProveedores()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select Nombre from Proveedor a, PersonaJuridica b where a.Id = b.Id");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        public SqlDataReader obtenerServicios(string proveedor)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select a.Nombre from servicio a, proveedor b, personajuridica c where a.idproveedor = b.idproveedor and b.id = c.id and c.nombre = '"+proveedor+"'");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }
        /*
        public SqlDataReader obtenerProveedoresEvento(string evento)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select distinct pj.nombre from proveedor p, personajuridica pj, ordencompra oc, evento e where p.id = pj.id and p.idproveedor = oc.idproveedor and oc.idevento = e.idevento and e.nombre = '"+evento+"';");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }*/

        public SqlDataReader obtenerIdOrdenes(string evento)
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select oc.idordencompra from ordencompra oc, evento e where oc.idevento = e.idevento and e.nombre = '" + evento + "';");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        public int agregarOrdenCompra(string idordencompra, string evento, string proveedor, string fecha)
        {
            String insertar = "INSERT INTO OrdenCompra (IdOrdenCompra, IdEvento, IdProveedor, Fecha) VALUES('"+idordencompra+ "',(select a.Idevento from evento a where a.nombre ='" + evento + "'),(select a.IdProveedor from Proveedor a, PersonaJuridica b where b.nombre ='" + proveedor + "' and a.Id = b.Id),'" + fecha + "');";
            return bd.actualizarDatos(insertar);
        }

        public int agregarLineaOrden(string idordencompra, string idlineaorden, string servicio, int cantidad)
        {
            String insertar = "INSERT INTO LineaOrden (IdOrdenCompra, IdLineaOrden, IdServicio, Cantidad) VALUES('"+idordencompra+"','" + idlineaorden + "',(select a.idservicio from servicio a where a.nombre ='" +servicio+ "')," + cantidad+ ");";
            return bd.actualizarDatos(insertar);

        }

    }

}
