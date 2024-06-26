﻿using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Service.Services.DTOs;

namespace KatmanliBurger.Service.Services.MenuServices
{
    public interface IMenuService
    {
		void Create(Menu entity);
		void Update(Menu entity);
		void UpdateStatus(int id);
		Menu GetById(int id);
		IEnumerable<Menu> GetAll();
		MenuDto GetMenu(int menuId);
        public void UpdateMenu(MenuDto dto, int menuId, int[] selectedburgers, int[] selectedcitilezzetler, int[] selectedicecekler, int[] selectedtatlilar);
    }
}
