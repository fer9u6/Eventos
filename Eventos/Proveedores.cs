using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Proveedores
    {
        AccesoBaseDatos db;
        
        public Proveedores()
        {
            db = new AccesoBaseDatos();
        }
        public int agregarProveedor(string cedula, string nombre, string email, string contacto)
        {
            db.actualizarDatos("insert into Persona(Id) values('" + cedula + "')");
            db.actualizarDatos("insert into PersonaJuridica(Id,Correo,Contacto,Nombre) values ('" + cedula + "', '" + email + "', '" + contacto + "','" + nombre + "' )");
            return db.actualizarDatos("insert into Proveedor (Id) VALUES('" + cedula + "')");
        }
    }
}
