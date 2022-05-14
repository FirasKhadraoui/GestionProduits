using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using Data;

namespace Service
{
    public class FactureService : EntityService<Facture>, IFactureService
    {
        public FactureService(IUnitOfWork _utwk, IRepositoryBase<Facture> _repository) : base(_utwk, _repository)
        {
        }
    }
}
