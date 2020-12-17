using Entities;
using Interfaces;
using System.Collections.Generic;  

namespace DatabaseLayer
{
    public class DBCourseLayer : IDatabaseReaderWriter<Course>
    {
        public Course GetById(int id)
        {
            return null;  

        }

        public IList<Course> GetAll()
        {
            return null;
        }

        public bool Insert(Course instance)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Course Update(Course instance)
        {
            throw new System.NotImplementedException();
        }
    }
}