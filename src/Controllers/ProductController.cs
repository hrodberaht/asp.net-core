using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Linq;

namespace src.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        private int PageSize = 4;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List(int page = 1) 
            => View(_repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
    }
}