using Microsoft.EntityFrameworkCore;
using TBCWebApi.DTO;

namespace TBCWebApi.Repository.database.Configuration;

public class RelativePersonConfiguration : IEntityConfiguration
{
    public ModelBuilder _modelBuilder;

    public RelativePersonConfiguration(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    public bool Configure()
    {

        _modelBuilder.Entity<RelativePerson>()
            .HasKey(rp => new { rp.PersonId, rp.RelativeToId });

        _modelBuilder.Entity<RelativePerson>()
            .HasOne(rp => rp.Person)
            .WithMany(p => p.Persons)
            .IsRequired(false);

        _modelBuilder.Entity<RelativePerson>()
            .HasOne(rp => rp.RelativeTo)
            .WithMany(p => p.Relatives)
            .IsRequired(false);

        _modelBuilder.Entity<RelativePerson>()
            .Property(rp => rp.RelativePersonType)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        return true;
    }
}
