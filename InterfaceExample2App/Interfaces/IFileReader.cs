using System.Collections.Generic;

namespace Interfaces
{
    public interface IFileReader
    {
        IList<IStudent> Read();
    }
}