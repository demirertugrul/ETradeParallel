using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain.Entities;
using ETradeParallel.Persistence.Context;

namespace ETradeParallel.Persistence.Repositories
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ETradeParallelDbContext context) : base(context)
        {
        }
    }
}
