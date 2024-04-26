using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Service.Services.ByProductServices
{
    public interface IByProductService
    {
		void Create(ByProduct entity);
		void Update(ByProduct entity);
		void UpdateStatus(int id);
		ByProduct GetById(int id);
		IEnumerable<ByProduct> GetAll();
		List<ByProduct> GetProductsWithCategories();
		IEnumerable<ByProduct> GetByIdList(List<int> ids);
	}
}
