using KatmanliBurger.Dal.Configurations.Extensions;
using KatmanliBurger.Data.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliBurger.Dal.Configurations
{
	public class ParameterTypeConfiguration : IEntityTypeConfiguration<ParameterType>
	{
		public void Configure(EntityTypeBuilder<ParameterType> builder)
		{
			builder.AddSeedData();
		}
	}
}
