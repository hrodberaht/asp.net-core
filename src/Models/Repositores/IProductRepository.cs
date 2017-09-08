using System.Collections.Generic;

namespace src.Models
{
    public interface IProductRepository
    {
         IEnumerable<Product> Products {get;}
    }
}