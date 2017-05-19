using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("kurez605@gmail.com");
                    mailMessage.To.Add("kurez605@gmail.com");
                    mailMessage.Subject = txtSubject.Text;


                    mailMessage.Body = "<b>Sender Name : </b>" + txtName.Text + "<br/>"
                         + "<b>Sender Email : </b>" + txtEmail.Text + "<br/>"
                          + "<b>Comments : </b>" + txtComments.Text;
                    mailMessage.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials =
                        new System.Net.NetworkCredential("huntarofury@gmail.com", "huntaro605");
                    smtpClient.Send(mailMessage);

                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "SENT! Thank you for contacting us";

                    txtName.Enabled = false;
                    txtEmail.Enabled = false;
                    txtComments.Enabled = false;
                    txtSubject.Enabled = false;
                    Button1.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                // Log - Event Viewer or table
                // database table or event viewer
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "There is an unknown problem. Please try later";
            }
        }
    }
}