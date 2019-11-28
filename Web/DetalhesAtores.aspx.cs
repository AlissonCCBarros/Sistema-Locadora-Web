using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace Web
{
    public partial class DetalhesAtores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = 0;

            if (Request.QueryString["Id"] != null)
            {
                Id = Convert.ToInt32(Request.QueryString["Id"]);

                ArtistaDAL aDAL = new ArtistaDAL();
                Artista ObjArtista = aDAL.SelecinarArtista(Id);

                if (ObjArtista != null)
                {
                    Image1.ImageUrl = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(ObjArtista.ImgArtista));
                    lblNomeAtor.Text = ObjArtista.Nome.ToString();
                    lblData.Text = ObjArtista.DtNascimento.ToString("d");
                    lblNaci.Text = ObjArtista.Pais.ToString();

                    Repeater1.DataSource = ObjArtista.ListFilme;
                    Repeater1.DataBind();

                    ListView1.DataSource = ObjArtista.ListFilme;
                    ListView1.DataBind();
                }
            }
        }

    }
}