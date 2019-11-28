using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class MensagemDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideoManiaConnectionString"].ConnectionString;

        public void InserirMensagem(Mensagem objMensagem)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Mensagens VALUES (@nome, @email, @msg, GETDATE())";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objMensagem.Nome);
            cmd.Parameters.AddWithValue("@email", objMensagem.Email);
            cmd.Parameters.AddWithValue("@msg", objMensagem.Tx_Mensagem);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Mensagem> ListarMensagens()
        {

            List<Mensagem> listaMensagens = new List<Mensagem>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Mensagens ORDER BY Data DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                Mensagem objMensagem;

                while (dr.Read())
                {

                    objMensagem = new Mensagem();
                    objMensagem.Id_Mensagem = Convert.ToInt32(dr["Id_Mensagem"]);
                    objMensagem.Nome = Convert.ToString(dr["Nome"]);
                    objMensagem.Email = Convert.ToString(dr["Email"]);
                    objMensagem.Tx_Mensagem = Convert.ToString(dr["Mensagem"]);
                    objMensagem.Dt_Mensagem = Convert.ToDateTime(dr["Data"]);

                    listaMensagens.Add(objMensagem);

                }
            }

            conn.Close();

            return listaMensagens;
        }
    }
}

