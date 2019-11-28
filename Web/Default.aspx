<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="introducao">
			<div class="container">
				<h1 data-anime="400" class="fadeInDown">Buscanco os melhores filmes?</h1>
				<blockquote data-anime="800" class="fadeInDown quote-externo">
					<p>“Aqui na VideoMania nós temos os melhores filmes e os últimos lançamentos.”</p>
					
				</blockquote>
				<a data-anime="1200" href="Filmes.aspx" class="btn">Filmes</a>
			</div>
		</section>
		
    <section class="produtos container fadeInDown" data-anime="1600">
        <h2 class="subtitulo">Filmes Adicionados Recentemente</h2>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <ul class="produtos_lista">
                    <li class="grid-1-3">
                        <div class="produtos_icone">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"data:Image/jpg;Base64,"+Convert.ToBase64String((byte[])Eval("ImgCapa"))%>' Height="384"/>
                        </div>
                        <a href="DetalhesFilmes.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>"><h3><%#DataBinder.Eval(Container.DataItem,"Titulo") %></h3></a>
                        
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>

        


    </section>
        

</asp:Content>
