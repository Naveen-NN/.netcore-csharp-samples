using System.Collections.Generic;  

namespace Interfaces
{
    public interface IDataBaseWriter<T>
    {
        bool Insert(T instance);  
        bool Delete(int id);  
        T Update(T instance);
    }
}

