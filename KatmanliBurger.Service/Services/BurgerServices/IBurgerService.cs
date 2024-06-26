﻿using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.Service.Services.BurgerServices
{
    public interface IBurgerService
    {
        void Create(Burger entity);
        void Update(Burger entity);
        void UpdateStatus(int id);
        Burger GetById(int id);
		IEnumerable<Burger> GetByIdList(List<int> ids);
		IEnumerable<Burger> GetAll();
        
    }
}
