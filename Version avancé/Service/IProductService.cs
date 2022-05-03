using Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IProductService : IEntityService<Product>
    {
        public IEnumerable<Product> FindMost5ExpensiveProds();
        public float UnavailableProductsPercentage();
        public IEnumerable<Product> GetProdsByCategory();

        public void DeleteOldProducts();
    }
}
