using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class MenuByProductMapping : BaseEntity
    {
     
        public int MenuId { get; set; }
        public int ByProductId { get; set; }

        //nav
        public virtual Menu Menu { get; set; }
        public virtual ByProduct ByProduct { get; set; }
    }
}
