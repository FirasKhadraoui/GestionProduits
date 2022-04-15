using Domain.entities;
using Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class FactureService : EntityService<Facture>, IFactureService
    {
        public FactureService(IUnitOfWork utwk, IRepositoryBase<Domain.entities.Facture> repository) : base(utwk, repository)
        {

        }
    }
}
