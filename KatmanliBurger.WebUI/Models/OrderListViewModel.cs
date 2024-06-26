﻿using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.WebUI.Models
{
	public class OrderListViewModel
	{
        public OrderListViewModel()
        {
            Orders = new List<Order>();
        }
        public int OrderNo { get; set; }
        public List<Order> Orders { get; set; }
        public Order Order { get; set; }
        public decimal TotalPrice { get; set; }
        public AppUser AppUser { get; set; }

		public virtual ICollection<BurgerOrderMapping>? BurgerOrders { get; set; }
		public virtual ICollection<MenuOrderMapping>? MenuOrders { get; set; }
		public virtual ICollection<OrderByProductMapping>? OrderByProducts { get; set; }
	}
}
