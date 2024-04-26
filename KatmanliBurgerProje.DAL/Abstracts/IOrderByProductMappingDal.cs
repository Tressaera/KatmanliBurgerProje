using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IOrderByProductMappingDal:IBaseDal<OrderByProductMapping>
    {
		void Create(IEnumerable<OrderByProductMapping> entities);
		void Update(IEnumerable<OrderByProductMapping> entities);
		IEnumerable<OrderByProductMapping> GetByOrderId(int id);
		IEnumerable<OrderByProductMapping> GetByProductId(int id);
		void Delete(IEnumerable<OrderByProductMapping> entities);
		IEnumerable<OrderByProductMapping> GetAll(Expression<Func<OrderByProductMapping, bool>> expression = null);
	}
}
