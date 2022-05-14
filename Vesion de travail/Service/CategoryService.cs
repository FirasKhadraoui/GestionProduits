using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;

namespace Service
{
    public class CategoryService : EntityService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork _utwk, IRepositoryBase<Category> _repository) : base(_utwk, _repository)
        {
        }
    }
}
