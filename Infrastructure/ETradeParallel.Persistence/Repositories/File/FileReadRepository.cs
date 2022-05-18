using ETradeParallel.Application.Repositories;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<ETradeParallel.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ETradeParallelDbContext context) : base(context)
        {
        }
    }
}
