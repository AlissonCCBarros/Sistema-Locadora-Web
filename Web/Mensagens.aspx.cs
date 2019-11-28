using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Web
{
    public partial class Mensagens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarMensagens();
        }

        private void CarregarMensagens()
        {
            MensagemDAL mDAL = new MensagemDAL();

            Repeater1.DataSource = mDAL.ListarMensagens();

            Repeater1.DataBind();

        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}