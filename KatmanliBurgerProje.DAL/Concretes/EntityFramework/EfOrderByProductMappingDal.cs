using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
	public class EfOrderByProductMappingDal : EfBaseDal<OrderByProductMapping, BurgerDbContext>, IOrderByProductMappingDal
	{
		public void Create(IEnumerable<OrderByProductMapping> entities)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				context.OrderByProducts.AddRange(entities);
				context.SaveChanges();
			}
		}

		public void Delete(IEnumerable<OrderByProductMapping> entities)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				context.OrderByProducts.RemoveRange(entities);
				context.SaveChanges();
			}
		}

		public IEnumerable<OrderByProductMapping> GetByOrderId(int id)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				return context.OrderByProducts.Where(x => x.OrderId == id).ToList();
			}
		}

		public IEnumerable<OrderByProductMapping> GetByProductId(int id)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				return context.OrderByProducts.Where(x => x.ByProductId == id).ToList();
			}
		}

		public void Update(IEnumerable<OrderByProductMapping> entities)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				context.OrderByProducts.UpdateRange(entities);
				context.SaveChanges();
			}
		}
	}
}
