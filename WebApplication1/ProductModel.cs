using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ProductModel
    {

        public string InsertProduct(Product product)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                db.Products.Add(product);
                db.SaveChanges();

                return product.Name + "was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }

        }

        public string UpdateProduct(int id, Product product)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();

                //fetch objects from database
                Product p = db.Products.Find(id);

                p.Name = product.Name;
                p.Price = product.Price;
                p.TypeID = product.TypeID;
                p.Description = product.Description;
                p.Image = product.Image;

                db.SaveChanges();
                return product.Name + "was successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProduct(int id)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                Product product = db.Products.Find(id);

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.Name + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                using (db_1525593_co5027Entities db = new db_1525593_co5027Entities())
                {
                    Product product = db.Products.Find(id);
                    return product;

                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (db_1525593_co5027Entities db = new db_1525593_co5027Entities())
                {
                    List<Product> products = (from x in db.Products
                                              select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetProductsByType(int typeId)
        {
            try
            {
                using (db_1525593_co5027Entities db = new db_1525593_co5027Entities())
                {
                    List<Product> products = (from x in db.Products
                                              where x.TypeID == typeId
                                              select x).ToList();
                    return products;

                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}