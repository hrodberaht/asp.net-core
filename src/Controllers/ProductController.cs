using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List() => View(_repository.Products);
    }
}