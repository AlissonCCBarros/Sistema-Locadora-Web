using System;
using System.Collections.Generic;
using Models;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class FilmeDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideoManiaConnectionString"].ConnectionString;
        public List<Filme> ListarFilmes()
        {

            List<Filme> listaFilmes = new List<Filme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT TOP 10 * FROM Filmes ORDER BY Id_Filme DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                Filme objFilme;

                while (dr.Read())
                {

                    objFilme = new Filme();
                    objFilme.Id = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.Cod_Barras = Convert.ToString(dr["Cod_Barras"]);
                    objFilme.Titulo = Convert.ToString(dr["Titulo"]);
                    objFilme.Ano = Convert.ToInt32(dr["Ano"]);
                    objFilme.Tipo = Convert.ToString(dr["Tipo"]);
                    objFilme.Preco = Convert.ToDecimal(dr["Preco"]);
                    objFilme.DataAquisicao = Convert.ToDateTime(dr["Dt_Aquisicao"]);
                    objFilme.ValorCusto = Convert.ToDecimal(dr["Vl_Custo"]);
                    objFilme.Locado = Convert.ToBoolean(dr["Situacao"]);
                    objFilme.Diretor = Convert.ToString(dr["Diretor"]);
                    objFilme.Descricao = Convert.ToString(dr["Descricao"]);
                    objFilme.ImgCapa = (byte[])dr["Img_Filme"];
                    
                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }

        public List<Filme> PesquisarFilmes(string titulo)
        {
            List<Filme> listaFilmes = new List<Filme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Filmes WHERE Titulo LIKE @Titulo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Titulo", "%" + titulo + "%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Filme objFilme;

                while (dr.Read())
                {
                    objFilme = new Filme();
                    objFilme.Id = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.Cod_Barras = Convert.ToString(dr["Cod_Barras"]);
                    objFilme.Titulo = Convert.ToString(dr["Titulo"]);
                    objFilme.Ano = Convert.ToInt32(dr["Ano"]);
                    objFilme.Tipo = Convert.ToString(dr["Tipo"]);
                    objFilme.Preco = Convert.ToDecimal(dr["Preco"]);
                    objFilme.DataAquisicao = Convert.ToDateTime(dr["Dt_Aquisicao"]);
                    objFilme.ValorCusto = Convert.ToDecimal(dr["Vl_Custo"]);
                    objFilme.Locado = Convert.ToBoolean(dr["Situacao"]);
                    objFilme.Diretor = Convert.ToString(dr["Diretor"]);
                    objFilme.Descricao = Convert.ToString(dr["Descricao"]);
                    objFilme.ImgCapa = (byte[])dr["Img_Filme"];

                    listaFilmes.Add(objFilme);
                }
            }
            conn.Close();
            return listaFilmes;
        }

        public Filme SelecinarFilme(int codigo)
        {
            Filme objFilme = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Filmes WHERE Id_Filme = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objFilme = new Filme();
                objFilme.Id = codigo;
                objFilme.Cod_Barras = Convert.ToString(dr["Cod_Barras"]);
                objFilme.Titulo = Convert.ToString(dr["Titulo"]);
                objFilme.Ano = Convert.ToInt32(dr["Ano"]);
                objFilme.Tipo = Convert.ToString(dr["Tipo"]);
                objFilme.Preco = Convert.ToDecimal(dr["Preco"]);
                objFilme.DataAquisicao = Convert.ToDateTime(dr["Dt_Aquisicao"]);
                objFilme.ValorCusto = Convert.ToDecimal(dr["Vl_Custo"]);
                objFilme.Locado = Convert.ToBoolean(dr["Situacao"]);
                objFilme.Diretor = Convert.ToString(dr["Diretor"]);
                objFilme.Descricao = Convert.ToString(dr["Descricao"]);
                objFilme.ImgCapa = (byte[])dr["Img_Filme"];

                objFilme.ListGenero = ListarGenero(codigo);
                objFilme.ListArtista = ListarAtores(codigo);
            }

            conn.Close();

            return objFilme;
        }

        public List<Genero> ListarGenero(int id)
        {
            List<Genero> listaGenero = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string sql = "SELECT * FROM Generos INNER JOIN Filmes_Generos ON Filmes_Generos.Id_Genero = Generos.Id_genero WHERE Filmes_Generos.Id_Filme = @id";
          
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Genero objGnero;

                while (dr.Read())
                {
                    objGnero = new Genero();
                    objGnero.Nome = dr["Nome"].ToString();

                    listaGenero.Add(objGnero);
                }
            }

            conn.Close();

            return listaGenero;
        }

        public List<Artista> ListarAtores(int id)
        {
            List<Artista> listaArtista = new List<Artista>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string sql = "SELECT Artistas.Id_Artista, Nome, Filmes_Artistas.Nm_Personagem FROM Artistas INNER JOIN Filmes_Artistas ON Filmes_Artistas.id_Artista = Artistas.Id_Artista WHERE Filmes_Artistas.Id_Filme = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Artista objArtista;

                while (dr.Read())
                {
                    objArtista = new Artista();
                    objArtista.Nome = dr["Nome"].ToString();
                    objArtista.NomePersonagem = dr["Nm_Personagem"].ToString();

                    listaArtista.Add(objArtista);
                }
            }

            conn.Close();

            return listaArtista;
        }
    }
}
