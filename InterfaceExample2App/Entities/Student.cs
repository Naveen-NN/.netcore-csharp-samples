//Concrete class or object 
using System.Collections.Generic;
using Interfaces;  

namespace Entities
{
    public class Student : IStudent
    {
        public string RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}