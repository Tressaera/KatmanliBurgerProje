using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class OrderByProductMapping : BaseEntity
    {
      
        public int OrderId { get; set; }
        public int ByProductId { get; set; }

        //nav
        public virtual Order Order { get; set; }
        public virtual ByProduct ByProduct { get; set; }
    }
}
