using Interfaces;  

namespace Factories
{
    public class MockFileReaderFactory : IFileReaderFactory
    {
        public IFileReader GetFileReader()
        {
            return new Mocks.MockFileReader();
        }
    }
}