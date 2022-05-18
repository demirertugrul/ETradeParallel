using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain.Entities;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ETradeParallelDbContext context) : base(context)
        {
        }
    }
}
