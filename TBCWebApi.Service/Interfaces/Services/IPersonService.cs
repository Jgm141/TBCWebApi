using TBCWebApi.DTO;

namespace TBCWebApi.Service.Interfaces.Services;

public interface IPersonService
{
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(int personId);
    Person GetPerson(int personId);
    IEnumerable<RelativePerson> GetPresonRelations(int personId);
}
