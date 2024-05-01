using Microsoft.EntityFrameworkCore;
using TBCWebApi.Repository;
using TBCWebApi.Service;
using TBCWebApi.Service.Interfaces.Repository;
using TBCWebApi.Service.Interfaces.Services;

namespace TBCWebApi.Configuration;

public static class DependencyConfiguration
{
    public static void ConfigureDependency(this WebApplicationBuilder builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IPersonService, PersonService>();
        builder.Services.AddDbContext<TBCWebApiDbContext>(options => options.UseSqlServer(connectionString));
    }
}
