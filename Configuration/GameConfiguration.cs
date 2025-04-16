using DotaNerf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotaNerf.Configuration;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(g => g.WinningTeam)
            .IsRequired();

        builder.HasOne(g => g.RadiantTeam)
            .WithOne()
            .HasForeignKey<Game>(g => g.RadiantTeamId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(g => g.DireTeam)
            .WithOne()
            .HasForeignKey<Game>(g => g.DireTeamId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
