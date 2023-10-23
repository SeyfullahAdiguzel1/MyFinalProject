using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    internal class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak",UnitPrice=15,UnitsInStock=10},
                 new Product{ProductId=2, CategoryId=1, ProductName="Kamera",UnitPrice=250,UnitsInStock=3},
                  new Product{ProductId=3, CategoryId=2, ProductName="Telefon",UnitPrice=1500,UnitsInStock=200},
                   new Product{ProductId=4, CategoryId=2, ProductName="Klavye",UnitPrice=100,UnitsInStock=6},
                    new Product{ProductId=5, CategoryId=2, ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Uptade(Product product)
        {
            Product productToUptade = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUptade.ProductName = product.ProductName;
            productToUptade.CategoryId = product.CategoryId;
            productToUptade.UnitPrice = product.UnitPrice;
            productToUptade.UnitsInStock = product.UnitsInStock;

        }
    }
}
