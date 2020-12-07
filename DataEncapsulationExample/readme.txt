/*
    Session 3:
    We create bank account object  with necessary attrubutes
/*
1. Properties in C# 
    https://docs.microsoft.com/en-us/dotnet/csharp/properties

2. Generic List in C#
    https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/list-collection

3. OOPS Concepts  step by step  
    a. Abstraction:     Hiding unnecessary details from consumers  
    b. Encapsulation:   Group related properties, methods and other memebers  
                        are treated as a single unit or object

    c. Inheritance: Ability to create new class based on existing class 
    d. Polymorphism: We can have multiple classes that can be used 
                     interchangeably, even though each class implements
                     same properties or methods in different ways 



Types: 
----------------------------------------------------
1. An interest earning account:
    Will get a credit of 2% of the month-ending-balance.
2. A line of credit:
   Can have a negative balance, but not be greater in absolute value than the credit limit.
   Will incur an interest charge each month where the end of month balance isn't 0.
   Will incur a fee on each withdrawal that goes over the credit limit.
3. A gift card account:
   Can be refilled with a specified amount once each month, on the last day of the month.

   IntrestWillBeCharged or not charged  ?  

Followin example which we have done is not complete  
you can complete this sample by refering the below  Microsoft link  
https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming


public class Person
{
    private string FirstName { get;}
    private stirng LastName { get;}

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;  
        lastName = lastName;
    }
}


public class Employee 
{
    private string EmployeeID { get; }
    pubic Employee(string empId, string firstName, string lastName) 
    : base(firstName, lastName)
    {
        EmployeeID = empId;
    }
}

Employee employee  = new Employee("E12345", "Vivaan", "Naveen");