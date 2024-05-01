using TBCWebApi.DTO;
using TBCWebApi.Repository;
using TBCWebApi.Service.Interfaces.Repository;

namespace TBCWebApi.Repository;

public sealed class PersonRepository : RepositoryBase<Person>, IPersonRepository
{
    public PersonRepository(TBCWebApiDbContext context ) : base(context)
    {

    }
}
