using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.Service.Services.OrderServices
{
    public class OrderManager: IOrderService
    {
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public void Create(Order entity)
		{
			_orderDal.Create(entity);
		}

		public IEnumerable<Order> GetAll()
		{
			return _orderDal.GetAll();
		}

		public Order GetById(int id)
		{
			return _orderDal.GetById(id);
		}

		public List<Order> OrderWithDetailList(List<Order> orders)
		{
			return _orderDal.OrderWithDetailList(orders);
		}

		public Order OrderWithDetails(int orderId)
		{
			return _orderDal.OrderWithDetails(orderId);
		}

		public void Update(Order entity)
		{
			entity.UpdatedDate = DateTime.Now;
			_orderDal.Update(entity);
		}

		public void UpdateStatus(int id)
		{
			var order = _orderDal.GetById(id);
			order.Status = order.Status == Status.Active ? Status.Passive : Status.Active;
			order.UpdatedDate = DateTime.Now;
			_orderDal.Update(order);
		}
	}
}
