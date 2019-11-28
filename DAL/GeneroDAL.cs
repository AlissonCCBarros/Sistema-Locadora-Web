using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Models;


namespace DAL
{
    public class GeneroDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideoManiaConnectionString"].ConnectionString;
        public List<Genero> Pesquisar(string genero)
        {
            List<Genero> Pesquisar = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT g.Id_genero, g.Nome, f.Id_Filme, f.Titulo, f.Ano, f.Img_Filme FROM Filmes f" +
                " INNER JOIN Filmes_Generos fg ON fg.Id_Filme = f.Id_Filme" +
                " INNER JOIN Generos g ON g.Id_genero = fg.Id_Genero WHERE g.Nome LIKE @genero";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@genero", $"%{genero}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Genero objGenero;
                while (dr.Read())
                {
                    objGenero = new Genero();
                    objGenero.Id = Convert.ToInt32(dr["Id_Genero"]);
                    objGenero.Nome = dr["Nome"].ToString();
                    objGenero.IdFilme = Convert.ToInt32(dr["Id_Filme"]);
                    objGenero.AnoFilme = Convert.ToInt32(dr["Ano"]);
                    objGenero.ImgFilme = (byte[])dr["Img_Filme"];
                    objGenero.TituloFilme = dr["Titulo"].ToString();


                    Pesquisar.Add(objGenero);

                }
            }
            conn.Close();
            return Pesquisar;
        }

        public Genero SelecinarGenero(int codigo)
        {
            Genero objGenero = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Generos.Id_genero, Nome FROM Generos INNER JOIN Filmes_Generos ON Filmes_Generos.Id_Genero = Generos.Id_genero WHERE Filmes_Generos.Id_Filme = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objGenero = new Genero();
                objGenero.IdFilme = codigo;
                objGenero.Id = Convert.ToInt32(dr["Id_genero"]);
                objGenero.Nome = Convert.ToString(dr["Nome"]);
            }

            conn.Close();

            return objGenero;
        }

        
    }
}
