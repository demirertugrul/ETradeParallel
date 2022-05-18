using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain.Entities;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ETradeParallelDbContext context) : base(context)
        {
        }
    }
}
