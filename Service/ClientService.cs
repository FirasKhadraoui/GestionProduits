using Domain.entities;
using GP.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ClientService : EntityService<Client>, IClientService
    {
        public ClientService(IUnitOfWork utwk, IRepositoryBase<Domain.entities.Client> repository) : base(utwk, repository)
        {

        }
    }
}
