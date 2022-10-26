using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
namespace HandsOnAPIUsingEFCodeFirst.Interfaces
{
    public interface ProductInterface
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(int id);
        void Edit(Product product);
    }
}
