using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //to get current customers loggein user and displat item carts
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);
        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            List<Cart> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            double vat = subTotal * 0.34;
            double totalAmount = subTotal + vat + 10;

            litTotal.Text = "$" + subTotal;

            litVat.Text = "$" + vat;

            litTotalAmount.Text = "$" + totalAmount;


        }

        private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
        {
            {
                subTotal = new double();
                ProductModel model = new ProductModel();

                foreach (Cart cart in purchaseList)
                {
                    Product product = model.GetProduct(cart.ProductID);

                    ImageButton btnImage = new ImageButton
                    {
                        ImageUrl = string.Format("~/image/Products/{0}", product.Image),
                        PostBackUrl = string.Format("~/Product.aspx?id={0}", product.ID)
                    };
                    LinkButton lnkDelete = new LinkButton
                    {
                        PostBackUrl = string.Format("~/ShoppingCart.aspx?productId={0}", cart.ID),
                        Text = "Delete Item",
                        ID = "del" + cart.ID
                    };

                    lnkDelete.Click += Delete_Item;

                    int[] amount = Enumerable.Range(1, 20).ToArray();
                    DropDownList ddlAmount = new DropDownList
                    {
                        DataSource = amount,
                        AppendDataBoundItems = true,
                        AutoPostBack = true,
                        ID = cart.ID.ToString()
                    };

                    ddlAmount.DataBind();
                    ddlAmount.SelectedValue = cart.Amount.ToString();
                    ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;


                    //Table A
                    Table table = new Table { CssClass = "cartTable" };
                    TableRow a = new TableRow();
                    TableRow b = new TableRow();

                    TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
                    TableCell a2 = new TableCell
                    {
                        Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock",
                        product.Name, "Item No:" + product.ID),
                        HorizontalAlign = HorizontalAlign.Left,
                        Width = 350
                    };

                    TableCell a3 = new TableCell { Text = "Unit Price<hr/>" };
                    TableCell a4 = new TableCell { Text = "Quantity<hr/>" };
                    TableCell a5 = new TableCell { Text = "Item Total<hr/>" };
                    TableCell a6 = new TableCell { };

                    //Table B
                    TableCell b1 = new TableCell { };
                    TableCell b2 = new TableCell { Text = "$ " + product.Price };
                    TableCell b3 = new TableCell { };
                    TableCell b4 = new TableCell { Text = "$ " + Math.Round((cart.Amount * (double)product.Price), 2) };
                    TableCell b5 = new TableCell { };
                    TableCell b6 = new TableCell { };

                    a1.Controls.Add(btnImage);
                    a6.Controls.Add(lnkDelete);
                    b3.Controls.Add(ddlAmount);

                    a.Cells.Add(a1);
                    a.Cells.Add(a2);
                    a.Cells.Add(a3);
                    a.Cells.Add(a4);
                    a.Cells.Add(a5);
                    a.Cells.Add(a6);

                    b.Cells.Add(b1);
                    b.Cells.Add(b2);
                    b.Cells.Add(b3);
                    b.Cells.Add(b4);
                    b.Cells.Add(b5);
                    b.Cells.Add(b6);

                    table.Rows.Add(a);
                    table.Rows.Add(b);

                    pnlShoppingCart.Controls.Add(table);

                    subTotal += (cart.Amount * (double)product.Price);



                }
            }



            Session[User.Identity.GetUserId()] = purchaseList;
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int cartId = Convert.ToInt32(selectedList.ID);

            CartModel model = new CartModel();
            model.UpdateQuantity(cartId, quantity);

            Response.Redirect("~/ShoppingCart.aspx");
        }

        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteCart(cartId);

            Response.Redirect("~/ShoppingCart.aspx");
        }
    }
}
