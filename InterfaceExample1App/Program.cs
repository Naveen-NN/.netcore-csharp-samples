using System;
using System.Collections.Generic;

namespace InterfaceExample1App
{
    class Program
    {
        static void Main(string[] args)
        {
            // if( args.Length == 0 ) 
            // {
            //     Console.WriteLine("Enter the file path..");  
            //     return;  
            // }

            // string filePath = args[0];

            string filePath = @"c:\temp\students.txt";
            
            IFileReader reader  = FileReaderFactory.GetFileReader();
            
            List<IStudent> students  = reader.Read(filePath);

            foreach(IStudent student in students)
            {
                Console.WriteLine($"{student.Id}\t{student.FirstName}\t{student.LastName}");
            }

            Console.ReadKey();
        }
    }
}
