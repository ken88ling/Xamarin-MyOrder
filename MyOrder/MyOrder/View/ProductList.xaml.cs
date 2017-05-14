using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrder.Model;
using MyOrder.Persistence;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOrder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Product>();
        }

        public ProductList()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISqLiteDb>().GetConnection();

            Label homeLabel = new Label()
            {
                Text = "Product list by Warehouse",
                FontSize = 30
            };

            ListView listView = new ListView();
            var product = new Product[]
            {
                new Product(){Id = 1,Name = "Apple", Category = "Fruits", Price = 1.10, WarehouseId = 1},
                new Product(){Id = 1,Name = "Kai Lan", Category = "Vege", Price = 1.20, WarehouseId = 2},
                new Product(){Id = 1,Name = "Oranges", Category = "Fruits", Price = 1.30, WarehouseId = 3},
                new Product(){Id = 1,Name = "Carrot", Category = "Vege", Price = 1.40, WarehouseId = 1},
                new Product(){Id = 1,Name = "Grape", Category = "Fruits", Price = 1.50, WarehouseId = 2},
                new Product(){Id = 1,Name = "Sprout", Category = "Vege", Price = 1.60, WarehouseId = 3},
                new Product(){Id = 1,Name = "Perls", Category = "Fruits", Price = 1.70, WarehouseId = 1},
                new Product(){Id = 1,Name = "Chinese Kai Lan", Category = "Vege", Price = 1.80, WarehouseId = 2},
                new Product(){Id = 1,Name = "Bananas", Category = "Fruits", Price = 1.90, WarehouseId = 3},
            };
        }

        public void CreateProduct()
        {
            
        }
        
        public void GetProductByWarehouseId(int wareHouseId)
        {
            var getProduct = _connection.Table<Product>().Where(x => x.WarehouseId == wareHouseId).ToListAsync();
        }
    }
}
