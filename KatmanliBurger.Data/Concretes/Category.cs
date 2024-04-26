using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //nav
        public virtual ICollection<ByProduct> ByProducts { get; set; }
    }
}
