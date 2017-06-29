using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class AgregarUsuario
    {
        private AccesoBaseDatos bd;

        public AgregarUsuario()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarUsuario(string idempleado, string usuario, string rol, string clave)
        {
            Encriptor e = new Encriptor();
            return bd.actualizarDatos("insert into Usuario(IdEmpleado,Usuario,Rol,Clave) values('" + idempleado + "','" + usuario + "','" + rol + "','" + e.Encrypt(clave) + "')");
        }
    }
}
