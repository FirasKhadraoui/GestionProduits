﻿using System;
using System.Collections.Generic;
using System.Text;
using ServicePattern;
using Domain.Entities;

namespace Service
{
    public interface IClientService : IEntityService<Client>
    {
    }
}