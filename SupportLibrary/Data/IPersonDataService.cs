using SupportLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task DeletePerson(int id);
        Task<List<IPersonModel>> ReadPeopole();
        Task<IPersonModel> ReadPeopole(int id);
        Task UpdatePerson(IPersonModel person);
    }
}