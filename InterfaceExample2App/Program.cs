using System;
using Interfaces;  
using Factories;  
using System.Collections.Generic; 

namespace InterfaceExample2App
{
    class Program
    {
        static IFileReaderFactory factory;  
        static void Main(string[] args)
        {
            string mode  = "Mock";

            if( mode == "Mock")
            {
                factory = new MockFileReaderFactory();
            }
            else
            {
                factory = new FileReaderFactory();
            }
            
            IFileReader fileReader  = factory.GetFileReader();  
            
            IList<IStudent> students  = fileReader.Read();

            foreach(IStudent student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
