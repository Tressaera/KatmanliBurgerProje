using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.DomainModels;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
	public class EfParameterDal :EfBaseDal<ParameterDetail, BurgerDbContext>, IParameterDal
	{
	}
}
