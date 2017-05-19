using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ProductTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                db.ProductTypes.Add(productType);
                db.SaveChanges();

                return productType.Name + "was succesfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }

        }

        public string UpdateProductType(int id, ProductType productType)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();

                //fetch objects from database
                ProductType p = db.ProductTypes.Find(id);

                p.Name = productType.Name;


                db.SaveChanges();
                return productType.Name + "was successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProductType(int id)
        {
            try
            {
                db_1525593_co5027Entities db = new db_1525593_co5027Entities();
                ProductType productType = db.ProductTypes.Find(id);

                db.ProductTypes.Attach(productType);
                db.ProductTypes.Remove(productType);
                db.SaveChanges();

                return productType.Name + "was successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}
    