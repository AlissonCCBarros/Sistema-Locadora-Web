<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="contato container fadeInDown" data-anime="1200">
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1">
                <LayoutTemplate>
                    <table cellpadding="1" cellspacing="0" style="border-collapse:collapse; margin-top:100px; margin-left: 300px;">
                        <tr>
                            <td>
                                <table cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2" style="color: #5566e2; font-weight: 600; font-family:Arial, Helvetica, sans-serif">Acesso - Mensagens</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" style="color: #5566e2; font-weight: 600; font-family:Arial, Helvetica, sans-serif">Nome do Usuário:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server" Style="border: 3px solid #5566e2; margin: 5px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="O Nome do Usuário é obrigatório." ToolTip="O Nome do Usuário é obrigatório." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" style="color: #5566e2; font-weight: 600; font-family:Arial, Helvetica, sans-serif">Senha:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" Style="border: 3px solid #5566e2; margin: 5px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="A senha é obrigatória." ToolTip="A senha é obrigatória." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" runat="server" Text="Lembrar na próxima vez." style="color: #5566e2; font-family:Arial, Helvetica, sans-serif" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Fazer Logon" ValidationGroup="Login1" CssClass="btn btn-preto"  />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>
    </section>
    
</asp:Content>
