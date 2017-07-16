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
    class Servicios_conexion
    {
        AccesoBaseDatos bd;

        public Servicios_conexion()
        {
            bd = new AccesoBaseDatos();
        }

        public SqlDataReader obtenerServicios()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select distinct nombre from Servicio;");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            catch (SqlException ex)
            {
                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return datos;
        }
        public int eliminarServicio(string nombre)
        {
            return bd.actualizarDatos("exec dbo.eliminarServicio @nombre = '" + nombre + "';");
        }

        public int agregarServicio(string idProveedor, string Nombre, string Detalle, int Precio, int Costo)
        {
            String insertar = "INSERT INTO Servicio (IdServicio, IdProveedor, Nombre, Detalle, Precio, Costo) VALUES((select  top 1 IdServicio+ 1 from Servicio order by IdServicio desc),(select a.IdProveedor from Proveedor a, PersonaJuridica b where b.nombre ='" + idProveedor + "' and a.Id = b.Id),'" + Nombre + "','" + Detalle + "','" + Precio + "','" + Costo + "');";


            return bd.actualizarDatos(insertar);
        }

        

        public DataTable obtenerTabla(string filtroNombre, string filtroGeneral)
        {
            if (filtroNombre == "Seleccione")
            {
                filtroNombre = null;
            }
            else { }
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los estudiantes de la
                //base de datos
                if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from Servicio");
                }
                //Si el filtro de nombre no es nulo carga los estudiantes cuyo
                //nombre sea el que tiene el filtro
                else if (filtroNombre != null && filtroGeneral ==null) 
                {
                    
                    tabla = bd.ejecutarConsultaTabla("Select * from Servicio where Nombre = '" + filtroNombre + "'");
                }
                //Si el filtro general no es nulo cargan los estudiantes con
                //atributos que contengan ese filtro como parte del atributo(like)
                else if (filtroGeneral != null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("select * from Servicio a where Nombre like '%"+filtroGeneral+ "%' or Detalle like '%"+filtroGeneral+"%'");
                    
                }
                //Si ninguno de los filtros es nulo carga los estudiantes que
                // coincidan con ambos filtros
                else if (filtroGeneral != null && filtroNombre != null)
                {

                    tabla = bd.ejecutarConsultaTabla("Select * from Servicio where nombre = '"+filtroNombre+"' or nombre like '%"+filtroGeneral+"%' OR  detalle like '%"+filtroGeneral+"%'");
                    
                }
            }
            catch (SqlException ex)
            {
            }
            return tabla;
        }


    }
}