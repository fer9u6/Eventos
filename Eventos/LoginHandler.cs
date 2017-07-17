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
                    con.Close();
                    Menu menu = new Menu();
                    menu.Show();
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
