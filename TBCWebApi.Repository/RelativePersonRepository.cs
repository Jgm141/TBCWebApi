using TBCWebApi.DTO;
using TBCWebApi.Repository;
using TBCWebApi.Service.Interfaces.Repository;

namespace TBCWebApi.Repository;

internal class RelativePersonRepository : RepositoryBase<RelativePerson>, IRelativePersonRepository
{
    public RelativePersonRepository(TBCWebApiDbContext context) : base(context)
    {

    }
    public IEnumerable<RelativePerson> GetAllRelative(int personId) =>
           _dbSet.Where(a => a.PersonId == personId && a.RelativeToId != 0).ToList();
    public int GetAllRelativeCount(int personId) => GetAllRelative(personId).Count();
}
