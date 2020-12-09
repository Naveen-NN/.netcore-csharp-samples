using System;

namespace InterfaceExample1App
{
    public interface IStudent
    {
        string Id {get;set;}
        string FirstName {get;set;}

        string LastName {get;set;}

        DateTime DateOfBirth { get;set;}
    }
}