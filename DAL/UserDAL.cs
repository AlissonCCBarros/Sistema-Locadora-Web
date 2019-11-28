using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideoManiaConnectionString"].ConnectionString;

        public bool AutenticarUsuario(string usuario, string senha)
        {
            bool existe = false;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE LnUsuario = @usuario AND SnUsuario = @senha";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                existe = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return existe;
        }
    }
}
