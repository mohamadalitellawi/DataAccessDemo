using SupportLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task<List<IPersonModel>> ReadPeopole();
    }
}