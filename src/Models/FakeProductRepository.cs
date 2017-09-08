using System.Collections.Generic;

namespace src.Models
{
    public class FakeProductRepositiory : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>{
            new Product {ProductID = 1, Name = "Ball", Price = 21 },
            new Product {ProductID = 4, Name = "Toy", Price = 27 },
            new Product {ProductID = 6, Name = "Car", Price = 34 },
            new Product {ProductID = 5, Name = "Doll", Price = 21 },
            new Product {ProductID = 2, Name = "Tree", Price = 27 },
            new Product {ProductID = 3, Name = "Spiderman", Price = 34 },
            new Product {ProductID = 8, Name = "Mace", Price = 21 },
            new Product {ProductID = 7, Name = "Sword", Price = 27 },
            new Product {ProductID = 9, Name = "Gun", Price = 34 }
        };
    }

}