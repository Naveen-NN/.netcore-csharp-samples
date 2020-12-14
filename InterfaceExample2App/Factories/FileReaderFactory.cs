using Interfaces;  
using FileLibrary;  

namespace Factories
{
    public class FileReaderFactory : IFileReaderFactory
    {
        public IFileReader GetFileReader()
        {
            return new FileReader();
        }
    }
}