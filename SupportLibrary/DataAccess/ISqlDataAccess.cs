using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storeProcedure, U parameters, string connectionStringName);
        Task SaveData<T>(string storeProcedure, T parameters, string connectionStringName);
    }
}