using ETradeParallel.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; } // Bu Customer Class Entity'si yani her bir Customer 1 den fazla sipariş verebilir.
    }
}
