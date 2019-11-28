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
    public partial class Filmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void pesquisarbtn_Click(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void CarregarFilmes()
        {
            string titulo = txtPesquisar.Text;
            FilmeDAL fDAL = new FilmeDAL();

            RepeaterFilmesP.DataSource = fDAL.PesquisarFilmes(titulo);
            RepeaterFilmesP.DataBind();
            
        }


        protected void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}