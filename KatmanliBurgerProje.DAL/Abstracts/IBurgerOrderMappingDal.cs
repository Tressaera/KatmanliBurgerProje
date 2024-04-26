using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IBurgerOrderMappingDal:IBaseDal<BurgerOrderMapping>
    {
		void Create(IEnumerable<BurgerOrderMapping> entities);
		void Update(IEnumerable<BurgerOrderMapping> entities);
		IEnumerable<BurgerOrderMapping> GetByOrderId(int id);
		IEnumerable<BurgerOrderMapping> GetByBurgerId(int id);
		void Delete(IEnumerable<BurgerOrderMapping> entities);
		IEnumerable<BurgerOrderMapping> GetAll(Expression<Func<BurgerOrderMapping,bool>>expression=null);
	}
}
