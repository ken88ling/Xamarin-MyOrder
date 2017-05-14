using System.Collections.ObjectModel;

namespace MyOrder.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }

        ObservableCollection<Product>products = new ObservableCollection<Product>();

    }
}
