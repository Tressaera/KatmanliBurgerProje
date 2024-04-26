using KatmanliBurger.Data.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliBurger.Dal.Configurations.Extensions
{
	public static class CategoryConfigurationExtension
	{
		public static void AddSeedData(this EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
			new Category() { Id = 1, Name = "İçecek", CreatedDate = DateTime.Now },
			new Category() { Id = 2, Name = "Patates", CreatedDate = DateTime.Now },
			new Category() { Id = 3, Name = "Tatlı", CreatedDate = DateTime.Now },
			new Category() { Id = 4, Name = "Atıştırmalık", CreatedDate = DateTime.Now });
		}
	}
}
