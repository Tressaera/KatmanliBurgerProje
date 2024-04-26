using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;
using Microsoft.EntityFrameworkCore;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
	public class EfByProductDal : EfBaseDal<ByProduct, BurgerDbContext>, IByProductDal
	{
		public List<ByProduct> GetProductsWithCategories()
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				var values = context.ByProducts.Include(x => x.Category).ToList();
				return values;
			}
		}
	}
}
