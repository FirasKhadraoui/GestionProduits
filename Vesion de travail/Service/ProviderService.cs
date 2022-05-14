using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;

namespace Service
{
    public class ProviderService : EntityService<Provider>, IProviderService
    {
        public ProviderService(IUnitOfWork _utwk, IRepositoryBase<Provider> _repository) : base(_utwk, _repository)
        {
        }
    }
}
