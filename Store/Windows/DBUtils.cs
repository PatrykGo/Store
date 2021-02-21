using Store.StoreModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Windows
{
    public class DBUtils
    {
        /// <summary>
        /// Dodawanie produktu do bazy
        /// </summary>
        public static bool addProduct(StoreDBEntities db, Category c, string name, double price)
        {
            try
            {
                Product p = new Product();
                p.name = name;
                p.price = price;
                p.Category_Id = c.Category_Id;
                db.Products.Add(p);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
