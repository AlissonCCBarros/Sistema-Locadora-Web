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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void CarregarFilmes()
        {
            FilmeDAL fDAL = new FilmeDAL();

            Repeater1.DataSource = fDAL.ListarFilmes();

            Repeater1.DataBind();

        }

    }
}