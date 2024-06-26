﻿using Microsoft.EntityFrameworkCore;

namespace TBCWebApi.Repository.database.Configuration;

public static class ModelBuilderExtension
{
    public static void ConfigureEntities(this ModelBuilder modelBuilder)
    {
        var configurationType = typeof(IEntityConfiguration);
        _ = (
          from t in typeof(IEntityConfiguration).Assembly.GetTypes()
          where configurationType.IsAssignableFrom(t) && !t.IsAbstract
          select (Activator.CreateInstance(t, modelBuilder) as IEntityConfiguration)?.Configure()
        ).ToArray();
    }


}
