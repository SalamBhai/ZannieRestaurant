using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Configurations
{
    public class TreatEntityTypeConfiguration : IEntityTypeConfiguration<Treat>
    {
        public void Configure(EntityTypeBuilder<Treat> builder)
        {
            builder.Property(b=>b.NumberofTreatsInPack).IsRequired();
            builder.Property(b=>b.Name).IsRequired();
            builder.Property(K=>K.TreatPrice).IsRequired();
            builder.Property(L=>L.DateofTreatregistration).IsRequired();
            builder.Property(L=>L.CategoryId).IsRequired();
        }
    }
}