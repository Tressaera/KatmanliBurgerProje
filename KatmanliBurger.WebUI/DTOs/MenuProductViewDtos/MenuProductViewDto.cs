﻿using KatmanliBurger.Data.Concretes;

namespace KatmanliBurger.WebUI.DTOs.MenuProductViewDtos
{
    public class MenuProductViewDto
    {
        public IEnumerable<Menu> Menus { get; set; }
        public IEnumerable<Burger> Burgers { get; set; }
        public IEnumerable<ByProduct> ByProducts { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
