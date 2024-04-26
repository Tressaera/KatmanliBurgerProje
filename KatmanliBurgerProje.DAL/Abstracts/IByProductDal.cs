using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IByProductDal:IBaseDal<ByProduct>
    {
		List<ByProduct> GetProductsWithCategories();
	}
}
