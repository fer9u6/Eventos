using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eventos
{
    class AgregaEvento
    {

        AccesoBaseDatos bd;

        public AgregaEvento()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarEvento(string IdEvento, string IdEmpleado, string IdCliente, string Nombre, string Tipo, int AsistenciaTotal, int AsistenciaEsperada, int Presupuesto, string Fecha, int CostoTotal, string Descripcion) { 
        {
            return bd.actualizarDatos("INSERT INTO Evento (IdEvento, IdEmpleado, IdCliente, Nombre, Tipo, AsistenciaTotal, AsistenciaEsperada, Presupuesto, Fecha, CostoTotal, Descripcion) VALUES('" + IdEvento + "','" + IdEmpleado + "','" + IdCliente + "','" + Nombre + "','" + Tipo + "','" + AsistenciaTotal + "','" + AsistenciaEsperada + "','" + Presupuesto + "','" + Fecha + "','" + CostoTotal + "','" + Descripcion + "')");
        }

        }

        public SqlDataReader obtenerEmpleados()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select IdEmpleado from Empleado a");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

        public SqlDataReader obtenerClientes()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select IdCliente from Cliente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }

    }
}
