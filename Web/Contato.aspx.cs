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
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            Mensagem objMensagem = new Mensagem();
            objMensagem.Nome = txtNome.Text;
            objMensagem.Email = txtEmail.Text;
            objMensagem.Tx_Mensagem = txtMensagem.Text;

            MensagemDAL mDAL = new MensagemDAL();
            mDAL.InserirMensagem(objMensagem);

            LimparCampos();

        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMensagem.Text = string.Empty; 
        }
    }
}