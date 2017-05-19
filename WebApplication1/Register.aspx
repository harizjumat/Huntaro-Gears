<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
</p>
<p>
    UserName:</p>
<p>
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
</p>
<p>
    Password:</p>
<p>
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
</p>
<p>
    Confirm Password:</p>
<p>
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Sign Up" />
</p>
</asp:Content>
