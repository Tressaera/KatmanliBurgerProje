using KatmanliBurger.Data.Concretes;
using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.WebUI.DTOs.ProductViewDtos
{
    public class ProductEditDto
    {
        public ByProduct ByProduct { get; set; }
        public List<Category> Categories { get; set; }
        public List<Size> Size { get; set; }
    }
}
