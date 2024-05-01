using TBCWebApi.DTO;
using TBCWebApi.Repository;
using TBCWebApi.Service.Interfaces.Repository;

namespace TBCWebApi.Repository;

internal class CityRepository : RepositoryBase<City>, ICityRepository 
{
    public CityRepository(TBCWebApiDbContext context) : base(context)
    {

    }
}
