using Domain.entities;
using Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service
{
    public class ProductService : EntityService<Product>, IProductService
    {
        public ProductService(IUnitOfWork utwk, IRepositoryBase<Domain.entities.Product> repository) : base(utwk, repository)
        {
            
        }

        public void DeleteOldProducts()
        {
            var listproduit = GetMany(p => (DateTime.Now - p.DateProd).TotalDays > 365);
            foreach (var p in listproduit)
            {
                Delete(p);
            }

            Commit();
        }

        public IEnumerable<Product> FindMost5ExpensiveProds()
        {
            return GetMany().OrderByDescending(p => p.price).Take(5);
        }

        public IEnumerable<Product> GetProdsByCategory(Categorie categorie)
        {
            return GetMany(p => p.categorie.name == p.categorie.name);
        }

        public IEnumerable<Product> GetProdsByCategory()
        {
            throw new NotImplementedException();
        }

        public float UnavailableProductsPercentage()

        {
            //quantite de produit =0 
            var quantity1 = GetMany(p => p.quantity == 0).Count();
            //quantite total de produit
            var quantity = GetMany().Count();

            return (quantity1 / quantity) * 100;
        }
    }
}
