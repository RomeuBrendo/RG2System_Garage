﻿using RG2System_Garage.Domain.Entities;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using RG2System_Garage.Infra.Repositories.Base;
using System;

namespace RG2System_Garage.Infra.Repositories
{
    public class RepositoryEstoqueProduto : RepositoryBase<EstoqueProduto, Guid>, IRepositoryEstoqueProduto
    {
        private readonly RB2System_GarageContext _context;
        public RepositoryEstoqueProduto(RB2System_GarageContext context) : base(context)
        {
            _context = context;
        }
    }
}
