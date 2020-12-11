using System;
using System.Collections.Generic;

namespace InterfaceExample1App
{
    public class JsonFileReader : IFileReader
    {
        public JsonFileReader()
        {
            Console.WriteLine("Json file reader");
        }
        public List<IStudent> Read(string path)
        {
             var students  = new List<IStudent>();  
            //TODO: Implementation 
            return students;
        }
    }
}