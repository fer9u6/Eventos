using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Empleado
    {
        private AccesoBaseDatos bd;

        /*Constructor de la clase estudiante*/
        public Empleado()
        {   //Se inicializa el objeto que realiza la conexión con la base de datos             
            bd = new AccesoBaseDatos();
        }


        /*Método para agregar un nuevo empleados a la base de datos         
         * Recibe: Los datos del nuevo empleado          
         * Modifica: inserta en la base de datos el nuevo empleado           
         * Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
         */
        public int agregarEmpleado(string cedula, string nombre, string ape1, string ape2, string email, string fechaNac, char genero, string idEmpleado, string idencargado, string idsucursal)
        {
            //Para agregar un empleado se debe agregar las tablas: persona, tipo de persona(fisica o juridica) y empleado
            string tipop = "F";
            String insertarp = "insert into Persona(Id,Tipo) values('" + cedula + "','"+tipop + "')";
            bd.actualizarDatos(insertarp);
            String insertarpf = "insert into PersonaFisica(Id,Apellido1,Apellido2,Nombre,Correo,FecNacimiento,Sexo) values ('" + cedula + "', '" + ape1 + "','" + ape2 + "', '" + nombre + "', '" + email + "','" + fechaNac + "','" + genero + "' )";
            bd.actualizarDatos(insertarpf);
            //String idEncargado
            String insertare = "insert into Empleado(Id,IdEmpleado,IdEncargado,IdSucursal)values('" + cedula + "','" + idEmpleado + "','" + idencargado + "','" + idsucursal + "')";
            return bd.actualizarDatos(insertare);
        }


        /*Método para obtener los nombres de los empleados de la base de datos          
         * Recibe: Nada          
         * Modifica: Realiza la selección de los nombres de empleado  y lo carga en un dataReader          
         * Retorna: el dataReader con los datos*/
        public SqlDataReader obtenerListaNombresEmpleados()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select p.Nombre from Empleado e , PersonaFisica p where e.Id = p.Id");
            }
            catch (SqlException ex) { }

            return datos;
        }



        /*Método para obtener los empleados de la base de datos          
         * Recibe: dos tipos de filtros por los cuales se pueden filtrar las tuplas          
         * Modifica: Realiza la selección de los empleados y los carga en un dataTable          
         * Retorna: el dataTable con los datos*/
        public DataTable obtenerEmpleados(string filtroNombre, string filtroGeneral)
        {
            if (filtroNombre == "Seleccione")
            {
                filtroNombre = null;
            }
            else { }
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los estudiantes de la base de datos              
                if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("select * from Empleado e,PersonaFisica p where e.Id = p.Id");
                }
                //Si el filtro de nombre no es nulo carga los estudiantes cuyo nombre sea el que tiene el filtro                 
                else if (filtroNombre != null )
                {

                    tabla = bd.ejecutarConsultaTabla("Select * from PersonaFisica p where Nombre ='" + filtroNombre + "'");
                }
                //Si el filtro general no es nulo cargan los estudiantes con atributos que contengan ese filtro como parte del atributo (like)                
                else if (filtroGeneral != null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from Empleado e,PersonaFisica p where e.Id =p.Id and (Nombre like '%" + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral + "%' OR Apellido2 like '%" + filtroGeneral + "%' OR cedula like '%" + filtroGeneral + "%')");
                }
                //Si ninguno de los filtros es nulo carga los estudiantes que coincidan con ambos filtros                 
                else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from Empleado e,PersonaFisica p where e.Id =p.Id and (Nombre ='" + filtroNombre + "' &&  Nombre like '%" + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral + "%' OR Apellido2 like '%" + filtroGeneral + "%' OR Id like '%" + filtroGeneral + "%')");

                }

            }
            catch (SqlException ex)
            {
            }

            return tabla;
        }


    }
}
