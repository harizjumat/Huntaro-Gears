<%@ Page Title="" Language="C#" MasterPageFile="~/huntaromaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="width:350px">
          <legend>Contact us </legend>
          <table>
              <tr>
                  <td>
                      <b> Name:</b>
                  </td>
                  <td>
                      <asp:TextBox ID="txtName" Width="200px" runat="server"></asp:TextBox>
                  </td>
                  <td>
                     <asp:RequiredFieldValidator 
                        ForeColor="Red" 
                        ID="RequiredFieldValidator1" 
                        runat="server"
                        ControlToValidate="txtName" 
                        ErrorMessage="Name is required" 
                        Text="*">
                    </asp:RequiredFieldValidator>
                           
                  </td>
              </tr>
                  <tr>
                <td>
                    <b>Email:</b>
                </td>
                <td>
                    <asp:TextBox 
                        ID="txtEmail" 
                        Width="200px" 
                        runat="server">
                    </asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator 
                        Display="Dynamic" 
                        ForeColor="Red" 
                        ID="RequiredFieldValidator2"
                        runat="server" 
                        ControlToValidate="txtEmail" 
                        ErrorMessage="Email is required"
                        Text="*">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator 
                        Display="Dynamic" 
                        ForeColor="Red" 
                        ID="RegularExpressionValidator1"
                        runat="server" 
                        ErrorMessage="Invalid Email" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ControlToValidate="txtEmail"
                        Text="*">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
                           <tr>
                  <td>
                      <b> Subject:</b>
                  </td>
                  <td>
                      <asp:TextBox ID="txtSubject" Width="200px" runat="server"></asp:TextBox>
                  </td>
                  <td>
                     <asp:RequiredFieldValidator 
                        ForeColor="Red" 
                        ID="RequiredFieldValidator3" 
                        runat="server"
                        ControlToValidate="txtSubject" 
                        ErrorMessage="Subject is required" 
                        Text="*">
                    </asp:RequiredFieldValidator>
                           
                  </td>
              </tr>
               <tr>
                  <td style="vertical-align:top">
                      <b> Comments:</b>
                  </td>
                  <td style="vertical-align:top">
                      <asp:TextBox ID="txtComments" Width="200px" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                  </td>
                  <td style="vertical-align:top">
                     <asp:RequiredFieldValidator 
                        ForeColor="Red" 
                        ID="RequiredFieldValidator4" 
                        runat="server"
                        ControlToValidate="txtComments" 
                        ErrorMessage="Comments are required" 
                        Text="*">
                    </asp:RequiredFieldValidator>
                           
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:ValidationSummary HeaderText="Please fix the following errors" ForeColor="Red" ID="ValidationSummary1" runat="server" />
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                  </td>
              </tr>
             
          </table>
       
      </fieldset>
            <h3>Our Location: </h3>
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3975.3232412742946!2d114.9283325293972!3d4.885431580495287!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x32228ac8ee3f7d03%3A0xcacd96016959ec39!2sLaksamana+College+of+Business!5e0!3m2!1sen!2sbn!4v1493195792923"/></iframe>

</asp:Content>
