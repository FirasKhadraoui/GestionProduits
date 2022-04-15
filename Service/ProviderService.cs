using Domain.entities;
using Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProviderService : EntityService<Provider>, IProviderService
    {
        public ProviderService(IUnitOfWork utwk, IRepositoryBase<Domain.entities.Provider> repository) : base(utwk, repository)
        {

        }
    }
}
