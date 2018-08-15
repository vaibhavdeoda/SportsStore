using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
       public IQueryable<Product> Products { get; set; }
       public PagingInfo PagingInfo { get; set; }
       public string CurrentCategory { get; set; } 
    }
}
