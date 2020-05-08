using SupportLibrary.DataAccess;
using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class PersonSqlDataService : IPersonDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public PersonSqlDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task CreatePerson(IPersonModel person)
        {
            var p = new
            {
                person.FirstName,
                person.LastName,
                person.DateOfBirth
            };

           await _dataAccess.SaveData("dbo.spPeopole_Create", p, "SQLDB");
        }

        public async Task<List<IPersonModel>> ReadPeopole()
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_Read",
                                                                          new { },
                                                                          "SQLDB");
            return people.ToList<IPersonModel>();
        }

        public async Task<IPersonModel> ReadPeopole( int id)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeopleReadOne",
                                                                          new { Id = id },
                                                                          "SQLDB");
            return people.FirstOrDefault();
        }

        public async Task UpdatePerson(IPersonModel person)
        {
           

            await _dataAccess.SaveData("dbo.spPeople_Update", person, "SQLDB");
        }

        public async Task DeletePerson(int id)
        {
            await _dataAccess.SaveData("dbo.spPeople_Delete", new { Id = id }, "SQLDB");
        }

        public async Task<List<IPersonModel>> SearchPeopole(string searchTerm)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_Search",
                                                                          new { SearchTerm = searchTerm },
                                                                          "SQLDB");
            return people.ToList<IPersonModel>();
        }
    }
}
