using Entities;
using Interfaces;
using System.Collections.Generic;  

namespace DatabaseLayer
{
    public class DBStudentLayer : IDatabaseReaderWriter<Student>
    {
        public Student GetById(int id)
        {
            return null;  

        }

        public IList<Student> GetAll()
        {
            return null;
        }

        public bool Insert(Student instance)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Student Update(Student instance)
        {
            throw new System.NotImplementedException();
        }
    }
}