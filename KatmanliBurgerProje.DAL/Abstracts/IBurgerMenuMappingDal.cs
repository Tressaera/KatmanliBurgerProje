using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IBurgerMenuMappingDal:IBaseDal<BurgerMenuMapping>
    {
		void Create(IEnumerable<BurgerMenuMapping> entities);
		void Update(IEnumerable<BurgerMenuMapping> entities);
		IEnumerable<BurgerMenuMapping> GetByMenuId(int id);
		IEnumerable<BurgerMenuMapping> GetByBurgerId(int id);
		void Delete(IEnumerable<BurgerMenuMapping> entities);
		List<BurgerMenuMapping> GetBurgerNamesForMenu();
	}
}
