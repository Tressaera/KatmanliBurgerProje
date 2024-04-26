using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Service.Services.CategoryServices
{
    public interface ICategoryService
    {
		void Create(Category entity);
		void Update(Category entity);
		void UpdateStatus(int id);
		Category GetById(int id);
		IEnumerable<Category> GetAll();
	}
}
