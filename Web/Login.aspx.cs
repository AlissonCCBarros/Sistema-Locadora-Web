using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using Models;
using DAL;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            string usuario = Login1.UserName;

            string senha = Criptografia.GetMD5Hash(Login1.Password);

            UserDAL uDAL = new UserDAL();

            e.Authenticated = uDAL.AutenticarUsuario(usuario, senha);
        }
    }
}