using System.Collections.Generic;
using Interfaces;

namespace Entities
{
    public class FileReader : IFileReader
    {
        public IList<IStudent> Read()
        {
            IList<IStudent>  students  = new List<IStudent>();  
            return students;
        }
    }
}