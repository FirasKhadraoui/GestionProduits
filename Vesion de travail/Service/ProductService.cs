using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;
using System.Linq;

namespace Service
{
    public class ProductService : EntityService<Product>, IProductService
    {
        public ProductService(IUnitOfWork _utwk, IRepositoryBase<Product> _repository) : base(_utwk, _repository)
        {
            
        }

        public List<Product> FindMost5ExpensiveProds()
        {
            return GetMany().OrderByDescending(p => p.Price).Take(5).ToList();
        }

        public float UnavailableProductsPercentage()
        {
            int nb_prod_non_dispo = (from p in GetMany(p => p.Quantity == 0) select p).Count();
            int nb_pro_totale = (from p in GetMany() select p).Count();
            return (float)(nb_prod_non_dispo / nb_pro_totale) * 100 ;
        }
    }
}
