using System;
namespace InterfaceExample1App
{
    public class Student : IStudent
    {
        public Student()
        {
        }

        public string Id { get; set;}

        public string FirstName { get; set;}

        public string LastName {get;set;}

        public DateTime DateOfBirth { get;set;}
    }
}