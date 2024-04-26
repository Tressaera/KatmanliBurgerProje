using KatmanliBurger.Dal.Configurations.Extensions;
using KatmanliBurger.Data.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliBurger.Dal.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.AddSeedData();
        }
    }
}
