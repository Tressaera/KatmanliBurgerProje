using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.Service.Services.CategoryServices
{
    public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Create(Category entity)
		{
			_categoryDal.Create(entity);
		}

		public IEnumerable<Category> GetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public void Update(Category entity)
		{
			entity.UpdatedDate = DateTime.Now;
			_categoryDal.Update(entity);
		}

		public void UpdateStatus(int id)
		{
			var category = _categoryDal.GetById(id);
			category.Status = category.Status == Status.Active ? Status.Passive : Status.Active;
			category.UpdatedDate = DateTime.Now;
			_categoryDal.Update(category);
		}
	}
}
