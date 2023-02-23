using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> entity)
        {
            entity.ToTable("Countries", "Settings");
            
            entity.Property(p=> p.Name).HasMaxLength(256).IsRequired();
            entity.Property(p=> p.PhoneAreaCode).HasMaxLength(50).IsRequired(false);

            //entity.Property(p => p.CreatedDate).IsRequired(false);
            entity.Property(p=> p.CreatedDate).IsRequired();
            entity.Property(p=> p.CreatedBy).HasMaxLength(100).IsRequired();
            
            entity.Property(p=> p.LastModifiedTime).IsRequired();
            entity.Property(p=> p.LastModifiedBy).HasMaxLength(100).IsRequired(false);

        }
    }
}
