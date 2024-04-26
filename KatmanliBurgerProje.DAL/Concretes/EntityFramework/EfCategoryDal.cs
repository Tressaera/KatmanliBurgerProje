using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
    public class EfCategoryDal : EfBaseDal<Category, BurgerDbContext>, ICategoryDal
    {
    }
}
