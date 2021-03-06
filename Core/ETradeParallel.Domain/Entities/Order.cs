using ETradeParallel.Domain.Entities.Base;

namespace ETradeParallel.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public Customer Customer{ get; set; } // Her bir Order ' ın Bir tane Customer'ı olmak zorunda yani ayni Siparişi iki kişi veremez.
        public ICollection<Product> Products { get; set; } // Her bir Order'da birden fazla Product olabilir.
    }
}
