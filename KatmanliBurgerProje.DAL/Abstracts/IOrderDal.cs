using KatmanliBurger.Dal.Abstracts.Base;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Abstracts
{
    public interface IOrderDal:IBaseDal<Order>
    {
		Order OrderWithDetails(int orderId);
		List<Order> OrderWithDetailList(List<Order> orders);
	}
}
