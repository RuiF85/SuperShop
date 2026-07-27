using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShop.Data.Entitis;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        public IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
