using System.Collections.Generic;
using Interfaces;
using Entities;

namespace Mocks
{
    public class MockFileReader : IFileReader
    {
        public IList<IStudent> Read()
        {
            return FillStudents();
        }

        private IList<IStudent> FillStudents()
        {
            var students = new List<IStudent>();  
            
            students.Add(new Student
            {
                FirstName = "Vivaan",  
                LastName ="Naveen",  
                DateOfBirth = "06/08/2013"
            });

            students.Add(new Student
            {
                FirstName = "Reyansh",  
                LastName ="R",  
                DateOfBirth = "06/08/2014"
            });
            
            return students;
        }
    }
}