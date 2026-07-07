using System.Linq;
using SuperShop.Data.Entitis;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        public IQueryable GetAllWithUsers();
    }
}
