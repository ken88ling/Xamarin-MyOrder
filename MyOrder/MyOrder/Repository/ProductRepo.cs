using System.Collections.Generic;
using System.Threading.Tasks;
using MyOrder.Model;
using Xamarin.Forms;
using SQLite;
using MyOrder.Persistence;

namespace MyOrder.Repository
{
    public class ProductRepo
    {
        protected SQLiteAsyncConnection Database;

        public ProductRepo()
        {
            Database = DependencyService.Get<ISqLiteDb>().GetConnection();
            Database.CreateTableAsync<Product>();
        }

        public async Task<int> CreateOrUpdateProduct(Product product)
        {
            if (product.Id != 0)
            {
                await Database.UpdateAsync(product);
                return product.Id;
            }
            else
            {
                return await Database.InsertAsync(product);
            }
        }

        public async Task<Product> GetProductById(int id)
        {
           return await Database.Table<Product>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByWarehouseId(int WareHouseId)
        {
            return await Database.Table<Product>().Where(x => x.WarehouseId == WareHouseId).ToListAsync();
        }

        public async void DeleteProductAsync(int id)
        {
            await Database.Table<Product>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
