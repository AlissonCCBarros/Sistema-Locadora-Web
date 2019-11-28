<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="Web.Contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    		<section class="introducao-interna interna_contato">
			<div class="container">
				<h1 data-anime="400" class="fadeInDown">Mande sua Menssagem</h1>
				
			</div>
		</section>

		<section class="contato container fadeInDown" data-anime="1200">
            <div id="form_orcamento" class="contato_form">
                    <label for="nome">Nome</label>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    <label for="email">E-mail</label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                    <br /><br />
                    <label for="mensagem">Mensagem</label>
                    <asp:TextBox ID="txtMensagem" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:Button ID="enviar" runat="server" Text="Enviar" class="btn btn-preto" style="width:200px; font-family:Arial, Helvetica, sans-serif" OnClick="enviar_Click"/>

                </div>
		</section>
</asp:Content>
