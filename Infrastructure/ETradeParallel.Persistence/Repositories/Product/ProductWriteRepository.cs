using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain.Entities;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETradeParallelDbContext dbContext) : base(dbContext)
        {
        }
    }
}
