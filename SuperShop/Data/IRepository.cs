using System.Collections.Generic;
using System.Threading.Tasks;
using SuperShop.Data.Entitis;

namespace SuperShop.Data
{
    public interface IRepository
    {
        void AddProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExists(int id);

        void RemoveProdutc(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProducts(Product product);
    }
}