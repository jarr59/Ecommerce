using EcommerceKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Products.Data.Mappings
{
    internal class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => new {  c.AccountId, c.Id });

            builder.Property(x => x.AccountId)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();

            builder.Property(x => x.Id)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();

            builder.Property(x => x.Name)
                   .HasMaxLength(GlobalValues.SHORTFIELD)
                   .IsRequired();

            builder.Property(x => x.ShortDescription)
                   .HasMaxLength(GlobalValues.LARGEFIELD)
                   .IsRequired(false);

            builder.OwnsOne(c => c.LargeDescription, e =>
            {
                e.Property(b => b.Value)
                 .HasMaxLength(GlobalValues.EXTRALARGEFIELD)
                 .IsRequired();
            });

            builder.Property(x => x.Brand)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired(false);

            builder.OwnsMany(x => x.Multimedias, e =>
            {
                e.WithOwner().HasForeignKey("AccountId", "Id");

                e.HasKey("AccountId", "Id", "MultimediaId");

                e.Property(b => b.MultimediaId)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();

                e.Property(b => b.MimeType)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();

                e.Property(b => b.Url)
                   .HasMaxLength(GlobalValues.EXTRALARGEFIELD)
                   .IsRequired();

                e.Property(b => b.Version)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();
            });

            builder.OwnsMany(x => x.DynamicFields, e =>
            {
                e.Property(b => b.Name)
                   .HasMaxLength(GlobalValues.KEYLENGHT)
                   .IsRequired();

                e.Property(b => b.Value)
                   .HasMaxLength(GlobalValues.SHORTFIELD)
                   .IsRequired();
            });
        }
    }
}
