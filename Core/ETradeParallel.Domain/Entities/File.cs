using ETradeParallel.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETradeParallel.Domain.Entities
{
    public class File : BaseEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }

        [NotMapped]
        public override DateTime UpdatedDate { get => base.UpdatedDate; set => base.UpdatedDate = value; }
    }
}
