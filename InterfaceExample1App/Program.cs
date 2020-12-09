using System;
using System.Collections.Generic;

namespace InterfaceExample1App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath =  "c:/tem/students.txt";
            
            IFileReader reader  = FileReaderFactory.GetFileReader();
            
            List<IStudent> students  = reader.Read(filePath);

        }
    }
}
