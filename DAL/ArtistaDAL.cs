using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class ArtistaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideoManiaConnectionString"].ConnectionString;

        public List<Artista> PesquisarArtista(string nome)
        {
            List<Artista> Pesquisar = new List<Artista>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE Nome LIKE @nome OR Pais LIKE @nome";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", $"%{nome}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Artista objArtista;

                while (dr.Read())
                {
                    objArtista = new Artista();
                    objArtista.Id = Convert.ToInt32(dr["Id_Artista"]);
                    objArtista.Nome = Convert.ToString(dr["Nome"]);
                    objArtista.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimento"]);
                    objArtista.Pais = Convert.ToString(dr["Pais"]);
                    objArtista.ImgArtista = (byte[])dr["Img_Artista"];


                    Pesquisar.Add(objArtista);
                }
            }
            conn.Close();

            return Pesquisar;
        }

        public List<Artista> PesquisarArtistaPais(string Pais)
        {
            List<Artista> Pesquisar = new List<Artista>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT Nome, Img_Artista FROM Artistas WHERE Pais LIKE @pais";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pais", $"%{Pais}%");

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Artista objArtista;
                if (dr.Read())
                {
                    objArtista = new Artista();
                    objArtista.Id = Convert.ToInt32(dr["Id_Artista"]);
                    objArtista.Nome = dr["Nome"].ToString();
                    objArtista.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimento"]);
                    objArtista.Pais = dr["Pais"].ToString();
                    objArtista.ImgArtista = (byte[])dr["Img_Artista"];

                    Pesquisar.Add(objArtista);
                }
            }
            conn.Close();
            return Pesquisar;
        }

        public Artista SelecinarArtista(int codigo)
        {
            Artista objArtista = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE Id_Artista = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objArtista = new Artista();
                objArtista.Id = codigo;
                objArtista.Nome = Convert.ToString(dr["Nome"]);
                objArtista.Pais = dr["Pais"].ToString();
                objArtista.ImgArtista = (byte[])dr["Img_Artista"];
                objArtista.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimento"]);

                objArtista.ListFilme = ListarFilmes(codigo);
            }

            conn.Close();

            return objArtista;
        }

        public List<Filme> ListarFilmes(int codigo)
        {

            List<Filme> listaFilmes = new List<Filme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Filmes.*, Filmes_Artistas.Nm_Personagem FROM Filmes INNER JOIN Filmes_Artistas ON Filmes_Artistas.Id_Filme = Filmes.Id_Filme WHERE Filmes_Artistas.id_Artista = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                Filme objFilme;

                while (dr.Read())
                {

                    objFilme = new Filme();
                    objFilme.Id = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.ImgCapa = (byte[])dr["Img_Filme"];
                    objFilme.Titulo = dr["Titulo"].ToString();
                    objFilme.NmPersonagem = dr["Nm_Personagem"].ToString();

                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }
    }
}

