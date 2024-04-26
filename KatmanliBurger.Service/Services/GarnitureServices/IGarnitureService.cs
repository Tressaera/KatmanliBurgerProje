using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Service.Services.GarnitureServices
{
    public interface IGarnitureService
    {
		void Create(Garniture entity);
		void Update(Garniture entity);
		void UpdateStatus(int id);
		Garniture GetById(int id);
		IEnumerable<Garniture> GetAll();
		IEnumerable<Garniture> GetByIdList(List<int> ids);
	}
}
