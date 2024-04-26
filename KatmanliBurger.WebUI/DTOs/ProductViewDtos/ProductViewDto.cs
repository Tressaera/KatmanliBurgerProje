using KatmanliBurger.Data.Enums;

namespace KatmanliBurger.WebUI.DTOs.ProductViewDtos
{
	public class ProductViewDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public decimal Price { get; set; }
		public string? Image { get; set; }
		public string? Description { get; set; }
		public string CategoryName { get; set; }
		public int Piece { get; set; } = 1;
		public Size Size { get; set; } = Size.Medium;
	
		
	}
}
