using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger.Service.Services.MenuOrderMappingServices
{
    public class MenuOrderMappingManager : IMenuOrderMappingService
	{
		private readonly IMenuOrderMappingDal _menuOrderMappingDal;

		public MenuOrderMappingManager(IMenuOrderMappingDal menuOrderMappingDal)
		{
			_menuOrderMappingDal = menuOrderMappingDal;
		}

		public void Create(IEnumerable<MenuOrderMapping> entities)
		{
			_menuOrderMappingDal.Create(entities);
		}

		public void Delete(IEnumerable<MenuOrderMapping> entities)
		{
			_menuOrderMappingDal.Delete(entities);
		}

		public IEnumerable<MenuOrderMapping> GetAll(Expression<Func<MenuOrderMapping, bool>> expression = null)
		{
			return _menuOrderMappingDal.GetAll(expression);
		}

		public IEnumerable<MenuOrderMapping> GetByMenuId(int id)
		{
			return _menuOrderMappingDal.GetByMenuId(id);
		}

		public IEnumerable<MenuOrderMapping> GetByOrderId(int id)
		{
			return _menuOrderMappingDal.GetByOrderId(id);
		}

		public void Update(IEnumerable<MenuOrderMapping> entities)
		{
			foreach (var entity in entities)
			{
				entity.UpdatedDate = DateTime.Now;
			}
			_menuOrderMappingDal.Update(entities);
		}
	}
}
