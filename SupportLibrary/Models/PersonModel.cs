using System;
using System.Collections.Generic;
using System.Text;

namespace SupportLibrary.Models
{
    public class PersonModel : IPersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
