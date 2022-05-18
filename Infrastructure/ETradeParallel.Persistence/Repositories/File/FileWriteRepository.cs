using ETradeParallel.Application.Repositories;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<ETradeParallel.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(ETradeParallelDbContext context) : base(context)
        {
        }
    }
}
