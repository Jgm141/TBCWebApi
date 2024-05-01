using Microsoft.EntityFrameworkCore;
using TBCWebApi.DTO;

namespace TBCWebApi.Repository.database.Configuration;

public class PersonConfiguration : IEntityConfiguration
{
    public ModelBuilder _modelBuilder;
    public PersonConfiguration(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    public bool Configure()
    {

        _modelBuilder.Entity<Person>()
            .Property(a => a.FirstName)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.LastName)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.Address)
            .HasColumnType("nvarchar(35)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.Gender)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.PersonalNumber)
            .HasColumnType("nvarchar(11)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.Birthday)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        _modelBuilder.Entity<Person>()
            .Property(a => a.picture)
            .HasColumnType("nvarchar(115)")
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        _modelBuilder.Entity<Person>()
            .HasOne(a => a.City)
            .WithMany(a => a.Person)
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .HasMany(a => a.PhoneNumber)
            .WithOne(a => a.Person)
            .IsRequired();

        _modelBuilder.Entity<Person>()
            .HasMany(a => a.Persons)
            .WithOne(a => a.Person)
            .IsRequired();

       _modelBuilder.Entity<Person>()
            .HasMany(a => a.Relatives)
            .WithOne(a => a.RelativeTo)
            .IsRequired();

        return true;
    }
}
