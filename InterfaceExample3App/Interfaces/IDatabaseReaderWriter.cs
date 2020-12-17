using System.Collections.Generic;  

namespace Interfaces
{
    public interface IDatabaseReaderWriter<T> : IDatabaseReader<T>, IDataBaseWriter<T>
    {
    }
}