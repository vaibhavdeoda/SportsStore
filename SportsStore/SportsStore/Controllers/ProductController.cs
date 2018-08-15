using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int pageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int productPage = 1) => View(new ProductsListViewModel { 
            Products = repository.Products
                                 .Where(p => category == null || p.Category == category)
                                 .OrderBy( p => p.ProductID)
                                 .Skip((productPage - 1) * pageSize)
                                 .Take(pageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = pageSize,
                TotalItems = repository.Products.Count()
            },
            CurrentCategory = category
        });
    }
}
