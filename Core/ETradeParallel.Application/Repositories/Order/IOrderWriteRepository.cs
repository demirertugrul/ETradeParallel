using ETradeParallel.Domain;
using ETradeParallel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Application.Repositories
{
    public interface IOrderWriteRepository : IWriteRepository<Order>
    {
    }
}
