using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Lab_13._2_Coffee_Shop_Product_List.Models
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            db.Open();
            List<Categories> cats = db.Query<Categories>("select * from Product").AsList<Categories>();
            db.Close();

            return View(cats);
        }

        public IActionResult Category(int catid)
        {
            IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=Lab13.2CoffeeShopProductList;user id=da;password=P@$$word!@#;");
            db.Open();
            Categories cat = db.QuerySingle<Categories>($"select * from Product where ID = {catid}");
            db.Close();
            return View(cat);
        }


    }
}
