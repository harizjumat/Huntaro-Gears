<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
<br />
<br />
Username:<br />
<br />
<asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
Password:<br />
<br />
<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" CssClass="button" OnClick="btnLogin_Click" Text="Login" />
</asp:Content>
