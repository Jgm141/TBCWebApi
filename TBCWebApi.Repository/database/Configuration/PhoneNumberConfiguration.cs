using Microsoft.EntityFrameworkCore;
using TBCWebApi.DTO;

namespace TBCWebApi.Repository.database.Configuration;

public class PhoneNumberConfiguration : IEntityConfiguration
{
    public ModelBuilder _modelBuilder;

    public PhoneNumberConfiguration(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    public bool Configure()
    {

        _modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.Number)
            .HasColumnType("nvarchar(25)")
            .IsRequired();

        _modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.PhoneNumberType)
            .HasColumnType("nvarchar(15)")
            .IsRequired();

        _modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.IsDelete)
            .HasColumnType("bit")
            .HasDefaultValue(false)
            .IsRequired();

        _modelBuilder.Entity<PhoneNumber>()
            .Property(a => a.CreateDate)
            .HasColumnType("date")
            .HasDefaultValueSql("GetDate()");

        _modelBuilder.Entity<PhoneNumber>()
            .HasOne(a => a.Person)
            .WithMany(a => a.PhoneNumber)
            .IsRequired();

        return true;
    }
}
