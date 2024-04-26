using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Service.Services.BurgerGarnitureMappingServices
{
    public interface IBurgerGarnitureMappingService
    {
		IEnumerable<BurgerGarnitureMapping> GetAll(Expression<Func<BurgerGarnitureMapping, bool>> expression = null);
		void Create(IEnumerable<BurgerGarnitureMapping> entities);
		void Update(IEnumerable<BurgerGarnitureMapping> entities);
		IEnumerable<BurgerGarnitureMapping> GetByBurgerId(int id);
		IEnumerable<BurgerGarnitureMapping> GetByBurgerIds(List<int> burgerIds);
		void Delete(IEnumerable<BurgerGarnitureMapping> entities);
	}
}
