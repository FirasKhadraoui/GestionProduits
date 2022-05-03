using Domain.entities;
using Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CategoryService : EntityService<Categorie>, ICategoryService
    {
        public CategoryService(IUnitOfWork utwk, IRepositoryBase<Categorie> repository) : base(utwk, repository)
        {

        }
    }

}
