using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_13._2_Coffee_Shop_Product_List.Models
{
    [Table("Product")]
    public class Product
    {
        //////Primary Key//////////////////
        [Key]
        public long ID { get; set; }////
        ///////////////////////////////// 
        

        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Category { get; set; }

        public static Product Create(string _name, string _description, Decimal _price, string _category)
        {
            //Create a new Product Instance
            Product prod = new Product() { Name = _name, Description = _description, Price = _price, Category = _category };

            //Sav it to the datebase
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            long _id = db.Insert<Product>(prod);

            //set th id column of the instance
            prod.ID = _id;

            //return the instance
            return prod;
        }

        public static List<Product> List()
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            List<Product> productlist = db.Query<Product>("select * from Product").AsList<Product>();
            return productlist;
        }

        public static Product Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            Product prod = db.Get<Product>(_id);
            return prod;
        }

        public static List<Product> Read()
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            List<Product> prods = db.GetAll<Product>().ToList();
            return prods;
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            db.Delete(new Product() { ID = _id });
        }

        public void Edit()
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            db.Update(this);
        }
    }
}
