using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IMenuOrderMappingDal:IBaseDal<MenuOrderMapping>
    {
		void Create(IEnumerable<MenuOrderMapping> entities);
		void Update(IEnumerable<MenuOrderMapping> entities);
		IEnumerable<MenuOrderMapping> GetByOrderId(int id);
		IEnumerable<MenuOrderMapping> GetByMenuId(int id);
		void Delete(IEnumerable<MenuOrderMapping> entities);
		IEnumerable<MenuOrderMapping> GetAll(Expression<Func<MenuOrderMapping, bool>> expression = null);
	}
}
