using System;
using Interfaces;  
using Entities;  
using DatabaseLayer;  

namespace InterfaceExample3App
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseReader<Student> studentReader  =  new DBStudentLayer(); 
            IDataBaseWriter<Student> studentWriter  =  new DBStudentLayer(); 
            IDatabaseReaderWriter<Student> studentReaderWriter  =  new DBStudentLayer(); 
        }
    }
}
