<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atores.aspx.cs" Inherits="Web.Atores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="contato container fadeInDown" data-anime="1200">
        <div id="form_orcamento" class="contato_form" style="padding-top: 100px">

                <asp:TextBox ID="txtPesquisar" runat="server" style="width: 800px"></asp:TextBox>
                <asp:Button ID="pesquisarbtn" runat="server" Text="PESQUISAR" class="btn btn-preto" style="width: 20%; font-family: Arial,Helvetica,sans-serif; float: right; margin-top: -49px; margin-right: -50px" OnClick="pesquisarbtn_Click"/>
        </div>
    </section>
    <section class="produtos container fadeInDown" data-anime="1600">
        <h2 class="subtitulo">Atores</h2>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <ul class="produtos_lista">
                    <li class="grid-1-3">
                        <div class="produtos_icone">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"data:Image/jpg;Base64,"+Convert.ToBase64String((byte[])Eval("ImgArtista"))%>' Height="250"/>
                        </div>
                        <a href="DetalhesAtores.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>"><h3><%#DataBinder.Eval(Container.DataItem,"Nome") %></h3></a>
                        
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>

        


    </section>
</asp:Content>
