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
    class Direccion
    {
        private AccesoBaseDatos bd;
        public Direccion()
        {
            bd = new AccesoBaseDatos();
        }

        public int agregarDireccion(string id,string tipo, string cpais,string cprovincia,string ccanton,string descripcion) {

            return bd.actualizarDatos("insert into Direccion(Id, Tipo, CodPais, CodProvincia, Codcanton, Descripcion)values('" + id + "','"+tipo+ "','"+cpais+ "','"+cprovincia+ "','"+ccanton+ "','"+descripcion+"')");

        }

        public SqlDataReader obtenerProvincias()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select descripcion from Provincia");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            return datos;
        }

        public SqlDataReader obtenerPaises()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.ejecutarConsulta("select descripcion from Pais ");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            return datos;
        }

        public SqlDataReader obtenerCantones()
        {
            SqlDataReader datos = null;
            try
            {
                    datos = bd.ejecutarConsulta("select descripcion from Canton ");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            return datos;
        }

        public SqlDataReader obtenerCantonesP(String codProvincia)
        {
            SqlDataReader datos = null;
            try
            {
                if (codProvincia == null)
                {
                    datos = bd.ejecutarConsulta("select descripcion from Canton ");
                }
                else
                {
                    datos = bd.ejecutarConsulta("select descripcion from Canton  where CodProvincia ='" + codProvincia + "'");
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show("error al hacer la consulta", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            return datos;
        }

        //recibe como parametro la descripcion y devuelve el codigo
        public string obtenerCodPais(string d) {
            
            string codPais = bd.ejecutarConsultaValor("select codPais from Pais where Descripcion= '" + d + "'");
            return codPais;
        }

        //recibe como parametro la descripcion y devuelve el codigo
        public string obtenerCodProvincia(string d)
        {

            string codProvincia = bd.ejecutarConsultaValor("select codProvincia from Provincia where Descripcion= '"+ d+ "'");
            return codProvincia;
        }

        //recibe como parametro la descripcion y devuelve el codigo
        public string obtenerCodCanton(string d)
        {
            string codCanton = bd.ejecutarConsultaValor("select codCanton from Canton where Descripcion= '" + d + "'");
            return codCanton;
        }





    }
}
