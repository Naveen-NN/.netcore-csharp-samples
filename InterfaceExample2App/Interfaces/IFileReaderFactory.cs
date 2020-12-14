using System.Collections.Generic;

namespace Interfaces
{
    public interface IFileReaderFactory
    {
        IFileReader GetFileReader();
    }
}