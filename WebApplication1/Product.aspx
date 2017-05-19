<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebApplication1.Product1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server"  CssClass="detailsImage" Height="400px" Width="400px"/></td>
            <td><h2>
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                <hr/>
                </h2></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label></td><br/>


        </tr>
        <tr>
            <td>Product No.: <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label>
               
            </td>
                          <td>  Quantity :
            <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br/>
                              </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label>
                 <asp:Button ID="btnAdd" runat="server" CssClass="button" Text="Add Product" OnClick="btnAdd_Click1" />
           

            </td>
            <td> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
            
        </tr>
    </table>
</asp:Content>
