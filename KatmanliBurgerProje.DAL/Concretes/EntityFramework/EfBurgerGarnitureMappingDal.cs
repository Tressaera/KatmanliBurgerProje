﻿using KatmanliBurger.Dal.Abstracts;
using KatmanliBurger.Dal.Contexts;
using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Dal.Concretes.EntityFramework
{
    public class EfBurgerGarnitureMappingDal : EfBaseDal<BurgerGarnitureMapping, BurgerDbContext>, IBurgerGarnitureMappingDal
    {
        public void Create(IEnumerable<BurgerGarnitureMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.BurgerGarnitures.AddRange(entities);
                context.SaveChanges();
            }
        }

		public void Delete(IEnumerable<BurgerGarnitureMapping> entities)
		{
            using (BurgerDbContext context=new BurgerDbContext())
            {
                context.BurgerGarnitures.RemoveRange(entities);
                context.SaveChanges();
            }
		}

		public IEnumerable<BurgerGarnitureMapping> GetByBurgerId(int id)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
               return context.BurgerGarnitures.Where(x=>x.BurgerId== id).ToList();
            }
        }

		public IEnumerable<BurgerGarnitureMapping> GetByBurgerIds(List<int> burgerIds)
		{
			using (BurgerDbContext context = new BurgerDbContext())
			{
				return context.BurgerGarnitures.Where(x => burgerIds.Contains(x.BurgerId)).ToList();
			}
		}

		public void Update(IEnumerable<BurgerGarnitureMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.BurgerGarnitures.UpdateRange(entities);
                context.SaveChanges();
            }
        }
    }
}
