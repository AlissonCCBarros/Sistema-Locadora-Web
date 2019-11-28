using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace Web
{
    public partial class DetalhesFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = 0;

            if (Request.QueryString["Id"] != null)
            {
                Id = Convert.ToInt32(Request.QueryString["Id"]);

                FilmeDAL fDAL = new FilmeDAL();
                Filme ObjFilme = fDAL.SelecinarFilme(Id);

                if( ObjFilme != null)
                {
                    Image1.ImageUrl = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(ObjFilme.ImgCapa));
                    lblAno.Text = ObjFilme.Ano.ToString();
                    lblTitulo.Text = ObjFilme.Titulo.ToString();
                    lblDescricao.Text = ObjFilme.Descricao.ToString();
                    lbldiretor.Text = ObjFilme.Diretor.ToString();

                    ListView1.DataSource = ObjFilme.ListGenero;
                    ListView1.DataBind();

                    ListView2.DataSource = ObjFilme.ListArtista;
                    ListView2.DataBind();
                }
            }



            

        }
    }
}