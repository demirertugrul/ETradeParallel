using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain;
using ETradeParallel.Domain.Entities;
using ETradeParallel.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETradeParallelDbContext dbContext) : base(dbContext)
        {
        }
    }
}
