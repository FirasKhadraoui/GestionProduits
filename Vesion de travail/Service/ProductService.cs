using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;

namespace Service
{
    public class ProductService : EntityService<Product>, IProductService
    {
        public ProductService(IUnitOfWork _utwk, IRepositoryBase<Product> _repository) : base(_utwk, _repository)
        {
        }
    }
}
