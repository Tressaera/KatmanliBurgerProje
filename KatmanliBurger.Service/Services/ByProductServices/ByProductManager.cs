﻿using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.Service.Services.ByProductServices
{
    public class ByProductManager: IByProductService
    {
		private readonly IByProductDal _byProductDal;

		public ByProductManager(IByProductDal byProductDal)
		{
			_byProductDal = byProductDal;
		}
		public void Create(ByProduct entity)
		{
			_byProductDal.Create(entity);
		}

		public IEnumerable<ByProduct> GetAll()
		{
			return _byProductDal.GetAll();
		}

		public ByProduct GetById(int id)
		{
			return _byProductDal.GetById(id);
		}

		public IEnumerable<ByProduct> GetByIdList(List<int> ids)
		{
			return _byProductDal.GetByIdList(ids);
		}

		public List<ByProduct> GetProductsWithCategories()
		{
			return _byProductDal.GetProductsWithCategories();
		}

		public void Update(ByProduct entity)
		{
			entity.UpdatedDate = DateTime.Now;
			_byProductDal.Update(entity);
		}

		public void UpdateStatus(int id)
		{
			var product = _byProductDal.GetById(id);
			product.Status = product.Status == Status.Active ? Status.Passive : Status.Active;
			product.UpdatedDate = DateTime.Now;
			_byProductDal.Update(product);
		}
	}
}
