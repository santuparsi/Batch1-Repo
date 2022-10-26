using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Interfaces
{
    interface IProductInterface
    {
        List<Product> GetProducts();
        Product GetProduct(int productId);
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
    }
}
