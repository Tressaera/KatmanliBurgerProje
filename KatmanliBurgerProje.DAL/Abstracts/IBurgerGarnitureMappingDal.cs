using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IBurgerGarnitureMappingDal:IBaseDal<BurgerGarnitureMapping>
    {
        void Create(IEnumerable<BurgerGarnitureMapping> entities);
        void Update(IEnumerable<BurgerGarnitureMapping> entities);
        IEnumerable<BurgerGarnitureMapping> GetByBurgerId(int id);
        IEnumerable<BurgerGarnitureMapping> GetByBurgerIds(List<int> burgerIds);
        void Delete(IEnumerable<BurgerGarnitureMapping> entities);
    }
}
