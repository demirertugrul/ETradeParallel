using ETradeParallel.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Persistence
{
    //DOTNOT CLI migration yapmak icin bunu yapmak gerekiyor.
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETradeParallelDbContext>
    {
        public ETradeParallelDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETradeParallelDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
