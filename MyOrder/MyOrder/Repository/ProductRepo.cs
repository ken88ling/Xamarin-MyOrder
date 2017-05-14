using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrder.Model;
using SQLite.Net;
using Xamarin.Forms;

namespace MyOrder.Repository
{
     public class ProductRepo
     {
        protected static object locker = new object();
         protected SQLiteConnection Database;

         public ProductRepo()
        {
            Database = DependencyService.Get<IDatabase>().DBCoonect();
            Database.CreateTable<Product>();
        }


    }
}
