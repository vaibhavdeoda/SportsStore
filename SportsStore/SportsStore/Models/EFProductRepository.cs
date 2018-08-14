using System.Linq;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext ApplicationDbContext;

        public EFProductRepository(ApplicationDbContext context)
        {
            ApplicationDbContext = context;
        }
        public IQueryable<Product> Products => ApplicationDbContext.Products;
    }
}
