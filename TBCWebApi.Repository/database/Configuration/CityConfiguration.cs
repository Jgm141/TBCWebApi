using Microsoft.EntityFrameworkCore;
using TBCWebApi.DTO;

namespace TBCWebApi.Repository.database.Configuration;

public class CityConfiguration : IEntityConfiguration
{
    public ModelBuilder _modelBuilder;
    public CityConfiguration(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public bool Configure()
    {
        _modelBuilder.Entity<City>()
            .Property(a => a.Name)
            .HasColumnType("nvarchar(20)")
            .IsRequired();

        _modelBuilder.Entity<City>()
            .HasIndex(a => a.Name)
            .IsUnique(true);

        _modelBuilder.Entity<City>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        _modelBuilder.Entity<City>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        _modelBuilder.Entity<City>().
            HasMany(p => p.Person)
            .WithOne(p => p.City)
            .IsRequired();

        return true;
    }
}
