namespace ETradeParallel.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
