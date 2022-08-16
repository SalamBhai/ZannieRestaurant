using Cakes_N_Treats_By_Zannie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cakes_N_Treats_By_Zannie.Configurations
{
    public class UserEntityTypeConfiguration :IEntityTypeConfiguration<User>
    {
         public void Configure(EntityTypeBuilder <User> builder)
        {
            builder.Property(Tenant=>Tenant.Id).HasColumnType("int").ValueGeneratedOnAdd();
            builder.ToTable("Users");
            builder.Property(Tenant=> Tenant.Password).IsRequired().HasMaxLength(32);
            builder.HasIndex(Tenat=> Tenat.Password).IsUnique();
            builder.HasIndex(Tenat=> Tenat.EmailAddress).IsUnique();
            builder.HasIndex(Tenat=> Tenat.PhoneNumber).IsUnique();
           
        }

       
    }
}