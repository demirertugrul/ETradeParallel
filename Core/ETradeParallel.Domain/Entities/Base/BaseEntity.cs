using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeParallel.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
