using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class PersonDummyDataService : IPersonDataService
    {
        private List<IPersonModel> people = new List<IPersonModel>();
        private int currentId = 0;

        public Task CreatePerson(IPersonModel person)
        {
            return Task.Run(() =>
            {
                //var largestPersonId = people.OrderByDescending(x => x.Id).FirstOrDefault();
                //int i = 1;
                //if (largestPersonId != null)
                //{
                //    i = largestPersonId.Id + 1;
                //}

                currentId += 1;
                person.Id = currentId;
                people.Add(person);
            });
        }

        public Task DeletePerson(int id)
        {
            return Task.Run(() =>
                {
                    people.Remove(people.Where(p => p.Id == id).FirstOrDefault());
                });
        }

        public Task<List<IPersonModel>> ReadPeopole()
        {
            return Task.FromResult(people);
        }

        public Task<IPersonModel> ReadPeopole(int id)
        {
            return Task.FromResult(people.Where(p => p.Id == id).FirstOrDefault());
        }

        public Task<List<IPersonModel>> SearchPeopole(string searchTerm)
        {
            return Task.FromResult(people.Where(p => p.FirstName.Contains(searchTerm)
                || p.LastName.Contains(searchTerm)).ToList());
        }

        public Task UpdatePerson(IPersonModel person)
        {
            return Task.Run(() =>
            {
                var p = people.Where(x => x.Id == person.Id).FirstOrDefault();
                if (p != null)
                {
                    p.FirstName = person.FirstName;
                    p.LastName = person.LastName;
                    p.DateOfBirth = person.DateOfBirth;

                }
            });
        }
    }
}
