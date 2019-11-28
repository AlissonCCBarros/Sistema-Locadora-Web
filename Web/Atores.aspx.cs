using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Web
{
    public partial class Atores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CarregarArtistas()
        {
            string nome = txtPesquisar.Text;
            ArtistaDAL aDAL = new ArtistaDAL();

            Repeater1.DataSource = aDAL.PesquisarArtista(nome);
            Repeater1.DataBind();

        }

        protected void pesquisarbtn_Click(object sender, EventArgs e)
        {
            CarregarArtistas();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CarregarArtistas();
        }
    }
}