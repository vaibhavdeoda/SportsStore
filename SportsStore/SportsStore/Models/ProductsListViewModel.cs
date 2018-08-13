using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class ProductsListViewModel
    {
       public IQueryable<Product> Products { get; set; }
    }
}
