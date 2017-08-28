using System.Collections.Generic;

namespace src.Models
{
    public class FakeProductRepositiory : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>{
            new Product {Name = "Ball", Price = 21 },
            new Product {Name = "Toy", Price = 27 },
            new Product {Name = "Car", Price = 34 }

        };
    }
}