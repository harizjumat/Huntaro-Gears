<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebApplication1.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="pnlShoppingCart" runat ="server">

    </asp:Panel>

    <table>
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td><b>Vat: </b></td>
            <td><asp:Literal ID="litVat" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td><b>Shipping </b></td>
            <td>$ 10</td>
        </tr>

        <tr>
            <td><b>Total Amount: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Contact.aspx"
                    Text="Continue Shopping" />
                OR
                <asp:Button ID="btnCheckout" runat="server" PostBackUrl="~/Success.aspx"
                    CssClass="button" Width="250px" Text="Continue Checkout"/>
            </td>
        </tr>
    </table>
</asp:Content>
