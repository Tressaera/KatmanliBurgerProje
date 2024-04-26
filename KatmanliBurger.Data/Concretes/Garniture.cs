using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.Concretes
{
    public class Garniture:BaseEntity
    {
        public string Name { get; set; }

        //nav

        public virtual ICollection<BurgerGarnitureMapping> BurgerGarnitures { get; set; }
    }
}
