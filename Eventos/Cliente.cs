using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

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
        public int agregarCliente(string cedula, string nombre, string ape1, string ape2, string email, string fechaNac, char genero, string idCliente,string telefono)
        {
            //Para agregar un cliente se debe agregar las tablas: persona, tipo de persona(fisica o juridica) y cliente
            string tipo = "F";
            string tipot = "R";
            bd.actualizarDatos("insert into Persona(Id,Tipo) values('" + cedula + "','" + tipo +"')");
            bd.actualizarDatos("insert into Telefono(Id,Tipo,Numero)values('" + cedula + "','" + tipot + "','" + telefono + "') " );
            bd.actualizarDatos("insert into PersonaFisica(Id,Apellido1,Apellido2,Nombre,Correo,FecNacimiento,Sexo) values ('" + cedula + "', '" + ape1 + "','" + ape2 + "', '" + nombre + "', '" + email + "','" + fechaNac + "','" + genero.ToString() + "' )");
            return bd.actualizarDatos("insert into Cliente(Id,IdCliente) values('" + cedula + "','" + idCliente + "')");
        }


        /*Método para agregar un nuevo cliente a la base de datos         
         * Recibe: Los datos del nuevo estudiante          
         * Modifica: inserta en la base de datos el nuevo estudiante          
         * Retorna: el tipo de error que generó la inserción o cero si la inserción fue exitosa
         */
        public int agregarClientePJuridica(string cedula, string nombre, string email, string contacto, string idCliente)
        {
            //Para agregar un cliente se debe agregar las tablas: persona, tipo de persona(fisica o juridica) y cliente
            string tipo = "J";
            bd.actualizarDatos("insert into Persona(Id,Tipo) values('" + cedula + "','" + tipo +"')");
            bd.actualizarDatos("insert into PersonaJuridica(Id,Correo,Contacto,Nombre) values ('" + cedula + "', '" + email + "', '" + contacto + "','" + nombre + "' )");
            return bd.actualizarDatos("insert into Cliente(Id,IdCliente) values('" + cedula + "','" + idCliente + "')");
        }



        /*Método para obtener los nombres de los clientes de la base de datos          
         * Recibe: Nada          
         * Modifica: Realiza la selección de los nombres de clientes y lo carga en un dataReader          
         * Retorna: el dataReader con los datos*/
        public SqlDataReader obtenerListaApellidosClientes()
        {  
            SqlDataReader datos = null;
                try
                {
                    datos = bd.ejecutarConsulta("select p.Apellido1 from Cliente e, PersonaFisica p where e.Id = p.Id ");
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            return datos;
        }


        /*Método para obtener los clientes de la base de datos          
         * Recibe: dos tipos de filtros por los cuales se pueden filtrar las tuplas          
         * Modifica: Realiza la selección de los estudiantes y los carga en un dataTable          
         * Retorna: el dataTable con los datos*/
        public DataTable obtenerClientes(string filtroApellido, string filtroGeneral,string tipoP)
        {
            if (filtroApellido == "Seleccione")
            {
                filtroApellido = null;
            }
            else { }


            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los CLIENTES           
                if (filtroGeneral == null && filtroApellido == null)
                {   if (tipoP == "Persona Fisica")
                    {
                        tabla = bd.ejecutarConsultaTabla("select * from Cliente c, PersonaFisica p  where c.Id = p.Id ");
                    }
                    else {
                        tabla = bd.ejecutarConsultaTabla("select * from Cliente c, PersonaJuridica p ");
                    }
                }
                //Si el filtro apellido y general nulo                
                else if (filtroApellido != null)
                {
                    if (tipoP == "Persona Fisica")
                    {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and p.Apellido1 ='" + filtroApellido+ "'or p.Apellido2 = '"+filtroApellido+"'");
                    }
                    else {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaJuridica  p  ");
                    }
                }
                //Si el filtro general no es nulo cargan losclientes con atributos que contengan ese filtro como parte del atributo (like)                
                else if (filtroGeneral != null && filtroApellido == null)
                {
                    if (tipoP == "Persona Fisica")
                    {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and (p.Nombre like '%" + filtroGeneral + "%' OR p.Apellido1 like '%" + filtroGeneral + "%' OR p.Apellido2 like '%" + filtroGeneral + "%' OR p.Id like '%" + filtroGeneral + "%')");
                    }
                    else
                    {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaJuridica p where  (p.Id like '%" + filtroGeneral + "%' OR p.Nombre like '%" + filtroGeneral + "%' OR p.Contacto like '%" + filtroGeneral + "%' OR p.Correo like '%" + filtroGeneral + "%')");
                    }
                }
                //Si ninguno de los filtros es nulo carga los estudiantes que coincidan con ambos filtros                 
                else if (filtroGeneral != null && filtroApellido != null)
                {
                    if (tipoP == "Persona Fisica")
                    {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaFisica p where c.Id = p.Id and( p.Apellido1='" + filtroApellido + "' &&  nombre like '%" + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral + "%' OR Apellido2 like '%" + filtroGeneral + "%' OR Id like '%" + filtroGeneral + "%')");
                    }
                    else
                    {
                        tabla = bd.ejecutarConsultaTabla("Select * from Cliente c, PersonaJuridica p where (p.Id like '%" + filtroGeneral + "%' OR p.Nombre like '%" + filtroGeneral + "%' OR p.Contacto like '%" + filtroGeneral + "%' OR p.Correo like '%" + filtroGeneral + "%')");
                    }
                }

            }
            catch (SqlException ex)
            {
            }

            return tabla;
        }



    }
}
