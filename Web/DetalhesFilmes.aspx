<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhesFilmes.aspx.cs" Inherits="Web.DetalhesFilmes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <br /><br /><br />  <br /><br /><br />
                <h2 class="subtitulo">
                    <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
                </h2>
                <section class="produtos container fadeInDown" data-anime="1600">
                    <ul class="produtos_lista">
                        <li class="grid-1-3">
                            <div class="produtos_icone">
                                <asp:Image ID="Image1" runat="server" Height="384" />
                            </div>                           
                        </li>
                    </ul>
        </section>
    <section class="contato container fadeInDown" data-anime="1200">
        <div id="form_orcamento" class="contato_form" style="float: left;  margin-top: -540px; margin-left: 350px">
            <div class="container" style="width: 200px; margin-left: 10px; border: 4px solid #5566e2; padding: 10px; text-align: center">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Ano de Lançamento -</p>
                <asp:Label ID="lblAno" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div class="container" style="width: 200px; margin-left: 10px; border: 4px solid #5566e2; padding: 10px;">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Direção -</p>
                <asp:Label ID="lbldiretor" runat="server" Text=""></asp:Label>
            </div>
            <br />  
            <div class="container" style="width: 155px; margin-left: 10px; border: 4px solid #5566e2;padding: 10px;">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Gêneros -</p>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                         <ul class="grid-1-3"><%# Eval("Nome") %></ul>
                </ItemTemplate>
            </asp:ListView>
            </div>
            <br />
            <div class="container" style="width: 350px; margin-left: 10px; border: 4px solid #5566e2;padding: 10px;">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Atores e Personagens -</p>
            <asp:ListView ID="ListView2" runat="server">
                <ItemTemplate>
                        <ul class="grid-1-3"><%# Eval("Nome") %> - <%# Eval("NomePersonagem") %></ul>
                </ItemTemplate>
            </asp:ListView>
                </div>
            <br />
            <div class="container" style="width: 600px; border: 4px solid #5566e2; padding: 10px; margin-left: 10px">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Sinopse -</p>
                <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </section>
</asp:Content>

