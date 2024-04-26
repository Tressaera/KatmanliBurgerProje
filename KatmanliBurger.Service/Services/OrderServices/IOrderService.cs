using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Service.Services.OrderServices
{
	public interface IOrderService
	{
		void Create(Order entity);
		void Update(Order entity);
		void UpdateStatus(int id);
		Order GetById(int id);
		IEnumerable<Order> GetAll();
		Order OrderWithDetails(int orderId);
		List<Order> OrderWithDetailList(List<Order> orders);
	}
}
