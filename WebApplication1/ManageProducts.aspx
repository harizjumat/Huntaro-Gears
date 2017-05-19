<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="WebApplication1.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
    Name:</p>
<p>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</p>
<p>
    Type:</p>
<p>
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="ID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525593_co5027ConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
</p>
<p>
    Price:</p>
<p>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
</p>
<p>
    Image:</p>
<p>
    <asp:DropDownList ID="ddlImage" runat="server">
    </asp:DropDownList>
</p>
<p>
    Description:</p>
<p>
&nbsp;<asp:TextBox ID="txtDescription" runat="server" Height="97px" TextMode="MultiLine" Width="269px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
</p>
<p>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
</asp:Content>
