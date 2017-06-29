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
    class Proveedores
    {
        AccesoBaseDatos db;
        
        public Proveedores()
        {
            db = new AccesoBaseDatos();
        }
        public int agregarProveedor(string cedula, string nombre, string email, string contacto)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=10.1.4.119;Initial Catalog=eventos;Integrated Security=False;User ID=B41441;Password=b41441;Connect Timeout=45;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Proveedor ",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int numProv = dt.Rows.Count + 1;
            db.actualizarDatos("insert into Persona(Id, Tipo) values('" + cedula + "', 'J')");
            db.actualizarDatos("insert into PersonaJuridica(Id,Correo,Contacto,Nombre) values ('" + cedula + "', '" + email + "', '" + contacto + "','" + nombre + "' )");
            return db.actualizarDatos("insert into Proveedor (Id, IdProveedor) VALUES('" + cedula + "', '" + numProv + "')");
        }
    }
}
