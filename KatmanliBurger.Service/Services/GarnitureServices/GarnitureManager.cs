using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.Service.Services.GarnitureServices
{
    public class GarnitureManager: IGarnitureService
    {
		private readonly IGarnitureDal _garnitureDal;

		public GarnitureManager(IGarnitureDal garnitureDal)
		{
			_garnitureDal = garnitureDal;
		}

		public void Create(Garniture entity)
		{
			_garnitureDal.Create(entity);
		}

		public IEnumerable<Garniture> GetAll()
		{
			return _garnitureDal.GetAll();
		}

		public Garniture GetById(int id)
		{
			return _garnitureDal.GetById(id);
		}

		public IEnumerable<Garniture> GetByIdList(List<int> ids)
		{
			return _garnitureDal.GetByIdList(ids);
		}

		public void Update(Garniture entity)
		{
			entity.UpdatedDate = DateTime.Now;
			_garnitureDal.Update(entity);
		}

		public void UpdateStatus(int id)
		{
			var garniture = _garnitureDal.GetById(id);
			garniture.Status = garniture.Status == Status.Active ? Status.Passive : Status.Active;
			garniture.UpdatedDate = DateTime.Now;
			_garnitureDal.Update(garniture);
		}
	}
}
