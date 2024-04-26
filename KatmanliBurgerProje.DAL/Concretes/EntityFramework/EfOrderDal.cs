using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;
using Microsoft.EntityFrameworkCore;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
	public class EfOrderDal : EfBaseDal<Order, BurgerDbContext>, IOrderDal
	{
		public Order OrderWithDetails(int orderId)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				return context.Orders.Include(o => o.BurgerOrders).ThenInclude(bo => bo.Burger).Include(o => o.MenuOrders).ThenInclude(mo => mo.Menu).Include(o => o.OrderByProducts).ThenInclude(obp => obp.ByProduct).Include(u => u.User).FirstOrDefault(o => o.Id == orderId);
			}
		}

		public List<Order> OrderWithDetailList(List<Order> orders)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				return context.Orders.Include(o => o.BurgerOrders).ThenInclude(bo => bo.Burger).Include(o => o.MenuOrders).ThenInclude(mo => mo.Menu).Include(o => o.OrderByProducts).ThenInclude(obp => obp.ByProduct).ToList();
			}
		}
		
	}
}
