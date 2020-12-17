using System.Collections.Generic;  

namespace Interfaces
{
    public interface IDatabaseReader<T>
    {
        T GetById(int id);  
        IList<T> GetAll();
    }
}

