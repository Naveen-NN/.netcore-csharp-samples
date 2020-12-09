using System.Collections.Generic;

namespace InterfaceExample1App
{
    public interface IFileReader
    {
        List<IStudent> Read(string path);
    }
}