using System.Collections.Generic;
using store.Models;

namespace src.Models
{
    public class EFProductReporitory : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public EFProductReporitory(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products => _context.Products;
    }
}