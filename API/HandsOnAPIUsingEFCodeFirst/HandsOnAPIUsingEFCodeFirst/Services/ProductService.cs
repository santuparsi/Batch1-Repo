using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Interfaces;
using HandsOnAPIUsingEFCodeFirst.Database;
namespace HandsOnAPIUsingEFCodeFirst.Services
{
    public class ProductService : ProductInterface
    {
        private readonly ECommerceDBContext context;
        public ProductService()
        {
            this.context = new ECommerceDBContext();
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public Product Get(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            return product;
        }

        public List<Product> GetAll()
        {
           return context.Products.ToList();
        }
    }
}
