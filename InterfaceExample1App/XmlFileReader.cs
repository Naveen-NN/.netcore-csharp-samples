using System.Collections.Generic;

namespace InterfaceExample1App
{
    public class XmlFileReader : IFileReader
    {
        public List<IStudent> Read(string path)
        {
           var students  = new List<IStudent>();  
            //TODO: Implementation 
            return students;
        }
    }
}