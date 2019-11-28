using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Web
{
    public partial class Generos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pesquisarbtn_Click(object sender, EventArgs e)
        {
            CarregarGenero();
        }

        private void CarregarGenero()
        {
            string genero = txtPesquisar.Text;
            GeneroDAL gDAL = new GeneroDAL();

            Repeater1.DataSource = gDAL.Pesquisar(genero);
            Repeater1.DataBind();

        }
    }
}