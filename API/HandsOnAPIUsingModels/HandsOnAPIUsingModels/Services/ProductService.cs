using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Interfaces;
using HandsOnAPIUsingModels.Models;

namespace HandsOnAPIUsingModels.Services
{
    public class ProductService : IProductInterface
    {
        public static List<Product> list = new List<Product>();
        public void AddProduct(Product product)
        {
            list.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            Product product = list.SingleOrDefault(i => i.ProductId == productId);
            list.Remove(product);
        }

        public Product GetProduct(int productId)
        {
            Product product = list.SingleOrDefault(i => i.ProductId == productId);
            return product;
        }

        public List<Product> GetProducts()
        {
            return list;
        }

        public void UpdateProduct(Product product)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[0].ProductId==product.ProductId)
                {
                    list[0].Price = product.Price;
                    list[0].Stock = product.Stock;
                    break;
                }
            }
        }
    }
}
