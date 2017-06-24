using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eventos
{
    class FacturaClass
    {
        AccesoBaseDatos bd;

        /* Constructor de la clase Factura */
        public FacturaClass()
        {
            //Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
        }

        /* Método para agregar una nueva factura a la base de datos */
        public int agregarFactura(string evento, string cliente, string servicio, string fecha, string detalle, int monto)
        {
            String insertar = "INSERT INTO FACTURA (IdEvento, IdCliente, IdServicio, fecha, detalle, monto) VALUES("
       + evento + ",'" + cliente + "', '" + servicio + "', '" + fecha + "','" + detalle + "', '" +
       monto + "', '" + 1 + "' )";
            return bd.actualizarDatos(insertar);
        }
    }
}
