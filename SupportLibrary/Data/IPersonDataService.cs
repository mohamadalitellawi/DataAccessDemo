using SupportLibrary.Models;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
    }
}