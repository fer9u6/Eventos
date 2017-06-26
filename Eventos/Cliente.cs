using System.Data;
using System.Data.SqlClient;
using System;

namespace Eventos
{
    class Cliente
    {
        private AccesoBaseDatos bd;

        /*Constructor de la clase cliente*/
        public Cliente()
        {   //Se inicializa el objeto que realiza la conexión con la base de datos             
            bd = new AccesoBaseDatos();
        }



        /*Método para agregar un nuevo cliente a la base de datos         
         * Recibe: Los datos del nuevo estudiante          
         * Modifica: inserta en la base de datos el nuevo estudiante          
         * Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
         */
        public int agregarCliente(string cedula, string nombre, string ape1, string ape2, string email, string fechaNac, char genero, string idCliente)
        {
            //Para agregar un cliente se debe agregar las tablas: persona, tipo de persona(fisica o juridica) y cliente

            String insertarp = "insert into Persona(Id) values('" + cedula + "')";
            bd.actualizarDatos(insertarp);
            String insertarpf = "insert into PersonaFisica(Id,Apellido1,Apellido2,Nombre,Correo,FecNacimiento,Sexo) values ('" + cedula + "', '" + ape1 + "','" + ape2 + "', '" + nombre + "', '" + email + "','" + fechaNac + "','" + genero.ToString() + "' )";
            bd.actualizarDatos(insertarpf);
            String insertarc = "insert into Cliente(Id,IdCliente) values('" + cedula + "','" + idCliente + "')";
            return bd.actualizarDatos(insertarc);
        }


        /*Método para agregar un nuevo cliente a la base de datos         
         * Recibe: Los datos del nuevo estudiante          
         * Modifica: inserta en la base de datos el nuevo estudiante          
         * Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
         */
        public int agregarClientePJuridica(string cedula, string nombre, string email, string contacto, string idCliente)
        {
            //Para agregar un cliente se debe agregar las tablas: persona, tipo de persona(fisica o juridica) y cliente

            String insertarp = "insert into Persona(Id) values('" + cedula + "')";
            bd.actualizarDatos(insertarp);
            String insertarpf = "insert into PersonaJuridica(Id,Correo,Contacto,Nombre) values ('" + cedula + "', '" + email + "', '" + contacto + "','" + nombre + "' )";
            bd.actualizarDatos(insertarpf);
            String insertarc = "insert into Cliente(Id,IdCliente) values('" + cedula + "','" + idCliente + "')";
            return bd.actualizarDatos(insertarc);
        }



        /*Método para obtener los nombres de los clientes de la base de datos          
         * Recibe: Nada          
         * Modifica: Realiza la selección de los nombres de clientes y lo carga en un dataReader          
         * Retorna: el dataReader con los datos*/
        public SqlDataReader obtenerListaNombresClientes()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select p.Nombre,j.Nombre from Cliente e, PersonaFisica p,PersonaJuridica j where e.Id = p.Id or e.Id = j.Id");
            }
            catch (SqlException ex) { }

            return datos;
        }


        /*Método para obtener los clientes de la base de datos          
         * Recibe: dos tipos de filtros por los cuales se pueden filtrar las tuplas          
         * Modifica: Realiza la selección de los estudiantes y los carga en un dataTable          
         * Retorna: el dataTable con los datos*/
        public DataTable obtenerClientes(string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los estudiantes de la base de datos              
                if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.ejecutarConsultaTabla("select * from Cliente c, PersonaFisica p ,PersonaJuridica j where c.Id = p.Id or j.Id = c.Id");
                }
                //Si el filtro de nombre no es nulo carga los estudiantes cuyo nombre sea el que tiene el filtro                 
                else if (filtroNombre != null)
                {

                    tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and p.Nombre ='" + filtroNombre + "'");
                }
                //Si el filtro general no es nulo cargan los estudiantes con atributos que contengan ese filtro como parte del atributo (like)                
                else if (filtroGeneral != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and (p.Nombre like '%" + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral + "%' OR Apellido2 like '%" + filtroGeneral + "%' OR Id like '%" + filtroGeneral + "%')");
                }
                //Si ninguno de los filtros es nulo carga los estudiantes que coincidan con ambos filtros                 
                else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and( p.Nombre='" + filtroNombre + "' &&  nombre like '%" + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral + "%' OR Apellido2 like '%" + filtroGeneral + "%' OR Id like '%" + filtroGeneral + "%')");

                }

            }
            catch (SqlException ex)
            {
            }

            return tabla;
        }



    }
}
