using DotaNerf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotaNerf.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
            .ValueGeneratedOnAdd();

        builder.Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(50) 
            .IsUnicode(false); 

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(320) 
            .IsUnicode(false); 

        builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(500);
    }
}

