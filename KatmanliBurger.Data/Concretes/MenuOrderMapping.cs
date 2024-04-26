using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class MenuOrderMapping : BaseEntity
    {
      
        public int MenuId { get; set; }
        public int OrderId { get; set; }

        //nav
        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
    }
}
