﻿using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Service.Services.BurgerMenuMappingServices
{
	public class BurgerMenuMappingManager : IBurgerMenuMappingService
	{
		private readonly IBurgerMenuMappingDal _burgerMenuMappingDal;

		public BurgerMenuMappingManager(IBurgerMenuMappingDal burgerMenuMappingDal)
		{
			_burgerMenuMappingDal = burgerMenuMappingDal;
		}

		public void Create(IEnumerable<BurgerMenuMapping> entities)
		{
			_burgerMenuMappingDal.Create(entities);
		}

		public void Delete(IEnumerable<BurgerMenuMapping> entities)
		{
			_burgerMenuMappingDal.Delete(entities);
		}

		public IEnumerable<BurgerMenuMapping> GetAll(Expression<Func<BurgerMenuMapping, bool>> expression = null)
		{
			return _burgerMenuMappingDal.GetAll(expression);
		}

		public List<BurgerMenuMapping> GetBurgerNamesForMenu()
		{
			return _burgerMenuMappingDal.GetBurgerNamesForMenu();
		}

		public IEnumerable<BurgerMenuMapping> GetByBurgerId(int id)
		{
			return _burgerMenuMappingDal.GetByBurgerId(id);
		}

		public IEnumerable<BurgerMenuMapping> GetByMenuId(int id)
		{
			return _burgerMenuMappingDal.GetByMenuId(id);
		}

		public void Update(IEnumerable<BurgerMenuMapping> entities)
		{
			foreach (var entity in entities)
			{
				entity.UpdatedDate = DateTime.Now;
			}
			_burgerMenuMappingDal.Update(entities);
		}
	}
}
