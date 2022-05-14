using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;

namespace Service
{
    public class ClientService : EntityService<Client>, IClientService
    {
        public ClientService(IUnitOfWork _utwk, IRepositoryBase<Client> _repository) : base(_utwk, _repository)
        {
        }
    }
}
