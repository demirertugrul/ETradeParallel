namespace ETradeParallel.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
