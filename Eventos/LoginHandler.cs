using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Eventos
{
    class LoginHandler
    {
        public LoginHandler()
        {
            
        }

        public int checkPassword(string usuario, string clave)
        {
            try
            {
                Encriptor encrypt = new Encriptor();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=10.1.4.119;Initial Catalog=eventos;Integrated Security=False;User ID=B41441;Password=b41441;Connect Timeout=45;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("select usuario,clave from Usuario where usuario='" + usuario + "'and clave='" + encrypt.Encrypt(clave) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1, cmd2, cmd3, cmd4;
                    SqlDataAdapter da1, da2, da3, da4;
                    DataTable dt1, dt2, dt3, dt4;
                    cmd1 = new SqlCommand("select usuario,clave from Usuario where usuario='" + usuario + "'and rol='Admin'and clave='" + encrypt.Encrypt(clave) + "'", con);
                    cmd2 = new SqlCommand("select usuario,clave from Usuario where usuario='" + usuario + "'and rol='Supervisor'and clave='" + encrypt.Encrypt(clave) + "'", con);
                    cmd3 = new SqlCommand("select usuario,clave from Usuario where usuario='" + usuario + "'and rol='Vendedor'and clave='" + encrypt.Encrypt(clave) + "'", con);
                    cmd4 = new SqlCommand("select usuario,clave from Usuario where usuario='" + usuario + "'and rol='Secretaria'and clave='" + encrypt.Encrypt(clave) + "'", con);
                    da1 = new SqlDataAdapter(cmd1);
                    da2 = new SqlDataAdapter(cmd2);
                    da3 = new SqlDataAdapter(cmd3);
                    da4 = new SqlDataAdapter(cmd4);
                    dt1 = new DataTable();
                    dt2 = new DataTable();
                    dt3 = new DataTable();
                    dt4 = new DataTable();
                    da1.Fill(dt1);
                    da2.Fill(dt2);
                    da3.Fill(dt3);
                    da4.Fill(dt4);
                    if () { }
                    else if () { }
                    else if () { }
                    else if () { }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Invalido.");
                    return 1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Conexion a la base de datos no disponible. Asegurese de estar conectado a la red correcta.");
            }
            return 0;
        }
    }
}
