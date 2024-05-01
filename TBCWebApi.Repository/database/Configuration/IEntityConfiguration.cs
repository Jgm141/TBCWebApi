using Microsoft.EntityFrameworkCore;

namespace TBCWebApi.Repository.database.Configuration;

public interface IEntityConfiguration
{
    bool Configure();
}
