using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class CartModel
    {
        public string InsertCart(Cart cart)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                db.Carts.Add(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }

        }

        public string UpdateCart(int id, Cart cart)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();

                //fetch objects from database
                Cart p = db.Carts.Find(id);

                p.DatePurchased = cart.DatePurchased;
                p.ClientID = cart.ClientID;
                p.Amount = cart.Amount;
                p.IsInCart = cart.IsInCart;
                p.ProductID = cart.ProductID;


                db.SaveChanges();
                return cart.DatePurchased + "was successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteCart(int id)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                Cart cart = db.Carts.Find(id);

                db.Carts.Attach(cart);
                db.Carts.Remove(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }


        public List<Cart> GetOrdersInCart(string userId)
        {
            db_1525593_co5027Entities db = new db_1525593_co5027Entities();
            List<Cart> orders = (from x in db.Carts
                                 where x.ClientID == userId
                                 && x.IsInCart
                                 orderby x.DatePurchased
                                 select x).ToList();
            return orders;
        }

        public int GetAmounOfOrders(string userId)

        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                int amount = (from x in db.Carts
                              where x.ClientID == userId
                              && x.IsInCart
                              select x.Amount).Sum();
                return amount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            db_1525593_co5027Entities db = new db_1525593_co5027Entities();
            Cart cart = db.Carts.Find(id);
            cart.Amount = quantity;

            db.SaveChanges();


        }

        public void MarkOrderAsPaid(List<Cart> carts)
        {
            db_1525593_co5027Entities db = new db_1525593_co5027Entities();

            if(carts != null)
            {
                foreach(Cart cart in carts)
                {
                    Cart oldCart = db.Carts.Find(cart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;
                }

                db.SaveChanges();
            }

        }


    }
}