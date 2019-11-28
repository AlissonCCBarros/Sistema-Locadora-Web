<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhesAtores.aspx.cs" Inherits="Web.DetalhesAtores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br />  <br /><br /><br />
                <h2 class="subtitulo">
                    <asp:Label ID="lblNomeAtor" runat="server" Text=""></asp:Label>
                </h2>
                <section class="produtos container fadeInDown" data-anime="1600">
                    <ul class="produtos_lista">
                        <li class="grid-1-3" style="    WIDTH: 250PX;">
                            <div class="produtos_icone">
                                <asp:Image ID="Image1" runat="server" Height="250" />
                            </div>                           
                        </li>
                    </ul>
        </section>
    <section class="contato container fadeInDown" data-anime="1200">
        <div id="form_orcamento" class="contato_form" style="float: left; margin-top: -400px; margin-left: 350px">
            <div class="container" style="width: 200px; margin-left: 10px; border: 4px solid #5566e2; padding: 10px; text-align: center">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Data de Nascimento -</p>
                <asp:Label ID="lblData" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div class="container" style="width: 200px; margin-left: 10px; border: 4px solid #5566e2; padding: 10px; text-align: center">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Nacionalidade -</p>
                <asp:Label ID="lblNaci" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div class="container" style="width: 350px; margin-left: 10px; border: 4px solid #5566e2; padding: 10px;">
                <p style="text-align: center; padding-bottom: 3px; font-family: Arial; font-weight: 600; color: #5566e2">- Filmes e Pesonagens -</p>
                <asp:ListView ID="ListView1" runat="server">
                    <ItemTemplate>
                        <ul class="grid-1-3"><%# Eval("Titulo") %> - <%# Eval("NmPersonagem") %></ul>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </section>
    <section class="produtos container fadeInDown" data-anime="1600" style="margin-top: -100px">
        <h2 class="subtitulo">FILMOGRAFIA</h2>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <ul class="produtos_lista">
                    <li class="grid-1-3" style="    width: 250px;">
                        <div class="produtos_icone">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"data:Image/jpg;Base64,"+Convert.ToBase64String((byte[])Eval("ImgCapa"))%>' Height="250"/>
                        </div>
                        <a href="DetalhesFilmes.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>"><h3><%#DataBinder.Eval(Container.DataItem,"Titulo") %></h3></a>
                        
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>
        </section>
</asp:Content>
