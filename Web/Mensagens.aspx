<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mensagens.aspx.cs" Inherits="Web.Mensagens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        		<section class="introducao-interna interna_contato">
			<div class="container">
				<h1 data-anime="400" class="fadeInDown">Mensagens</h1>
				
			</div>
		</section>		
    <section class="produtos container fadeInDown" data-anime="1600">
        

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <ul class="produtos_lista">
                    <li class="grid-1-3">
                        <div class="produtos_icone">
                            <h2 style="color:#ffffff">Nome:   <%#DataBinder.Eval(Container.DataItem,"Nome") %></h2>
                            <h2 style="color:#ffffff">Email:  <%#DataBinder.Eval(Container.DataItem,"Email") %></h2>
                        </div>
                        <h2 style="padding: 20px"><%#DataBinder.Eval(Container.DataItem,"Tx_Mensagem") %></h2>
                        
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>

        
        

    </section>

    <asp:LoginStatus ID="LoginStatus1" runat="server" style="float:right; font-family:Arial, Helvetica, sans-serif; margin:10px"/>

</asp:Content>
