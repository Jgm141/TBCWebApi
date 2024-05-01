using TBCWebApi.DTO;
using TBCWebApi.Repository;
using TBCWebApi.Service.Interfaces.Repository;

namespace TBCWebApi.Repository;

public sealed class PhoneNumberRepository : RepositoryBase<PhoneNumber>, IPhoneNumberRepository
{
    public PhoneNumberRepository(TBCWebApiDbContext context) : base(context)
    {

    }
}
