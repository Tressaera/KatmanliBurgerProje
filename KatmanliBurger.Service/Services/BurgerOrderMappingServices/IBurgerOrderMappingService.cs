﻿using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Service.Services.BurgerOrderMappingServices
{
    public interface IBurgerOrderMappingService
    {
		void Create(IEnumerable<BurgerOrderMapping> entities);
		void Update(IEnumerable<BurgerOrderMapping> entities);

		IEnumerable<BurgerOrderMapping> GetByBurgerId(int id);
		IEnumerable<BurgerOrderMapping> GetByOrderId(int id);
		IEnumerable<BurgerOrderMapping> GetAll(Expression<Func<BurgerOrderMapping, bool>> expression = null);
		void Delete(IEnumerable<BurgerOrderMapping> entities);
	}
}
