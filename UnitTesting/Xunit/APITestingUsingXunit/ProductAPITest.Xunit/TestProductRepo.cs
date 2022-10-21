using System;
using Xunit;
using ProductAPI.Repositories;
using ProductAPI.Models;
using System.Collections.Generic;

namespace ProductAPITest.Xunit
{
    public class TestProductRepo
    {
        private readonly ProductRepo repo;
        public TestProductRepo()
        {
            repo = new ProductRepo(new ProductDBContext());
        }
        [Fact]
        public void TestGetProducts()
        {
            List<Products> list = repo.GetProducts();
            Assert.NotNull(list);
        }
        [Fact]
        public void TestGetProduct()
        {
            Products product = repo.GetProduct(14);
            Assert.NotNull(product);
            Assert.Equal(14, product.Pid);
        }
        [Fact]
        public void TestGetProductReturnNull()
        {
            Products product = repo.GetProduct(100);
            Assert.Null(product);
           // Assert.Equal(1, product.Pid);
        }
        [Fact]
        public void TestAddProduct()
        {
            Products p = new Products() { Pname = "AAA", Price = 10, Stock = 10 };
            repo.AddProduct(p);
            Products product = repo.GetProduct(14);
            Assert.Equal(14,product.Pid);
        }
        [Fact]
        public void TestUpdateProduct()
        {

        }
        [Fact]
        public void TestDeleteProduct()
        {

        }

    }
}
