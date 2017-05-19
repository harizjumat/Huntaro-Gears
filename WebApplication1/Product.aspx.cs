﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Product1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }


        private void FillPage()
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductModel productModel = new ProductModel();
                Product product = productModel.GetProduct(id);

                lblPrice.Text = "Price per unit: <br/>$  " + product.Price;
                lblTitle.Text = product.Name;
                lblDescription.Text = product.Description;
                lblItemNr.Text = id.ToString();
                imgProduct.ImageUrl = "image/Products/" + product.Image;

                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();


            }
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientId = Context.User.Identity.GetUserId();

                if (clientId != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                    Cart cart = new Cart
                    {
                        Amount = amount,
                        ClientID = clientId,
                        DatePurchased = DateTime.Now,
                        IsInCart = true,
                        ProductID = id
                    };

                    CartModel model = new CartModel();
                    lblResult.Text = model.InsertCart(cart);
                }
                else
                {
                    lblResult.Text = "Please log in to order items";
                }
            }
        }
    }
}