using AutoMapper;
using KatmanliBurger.Data.Concretes;
using KatmanliBurger.WebUI.DTOs.ProductViewDtos;

namespace KatmanliBurger.WebUI.Mapping
{
	public class ByProductMapping:Profile
	{
        public ByProductMapping()
        {
			CreateMap<ByProduct, ProductViewDto>().
			ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.Name)).ReverseMap();
		}
    }
}
