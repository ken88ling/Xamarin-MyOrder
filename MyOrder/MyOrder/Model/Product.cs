using System.Collections.ObjectModel;
using SQLite;

namespace MyOrder.Model
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public int WarehouseId { get; set; }
        
        ObservableCollection<Product>products = new ObservableCollection<Product>();

    }
}
