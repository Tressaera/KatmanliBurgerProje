using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.Data.Abstracts
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
