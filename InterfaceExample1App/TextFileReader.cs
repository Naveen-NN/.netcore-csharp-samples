using System.Collections.Generic;
using System.IO;  

namespace InterfaceExample1App
{
    public class TextFileReader : IFileReader
    {
        public TextFileReader()
        {
            System.Console.WriteLine("Text file reader...");            
        }
        public List<IStudent> Read(string path)
        {
            var students  = new List<IStudent>();  
            
            //1. Read all lines from the file  
            string[] studentsData = File.ReadAllLines(path);

            //2. loop through each student data  
            foreach(string studentData in studentsData)
            {
                //3. extract the student data  
                IStudent student = ExtractData(studentData);
                //4.Add the student details to collection  
                students.Add(student);
            }

            return students;
        }

        private static IStudent ExtractData(string data)
        {
            IStudent student = new Student(); 
           
            string[] detail  = data.Split('|');
            student.Id = detail[TextFileReaderSchema.Columns.Id];  
            student.FirstName = detail[TextFileReaderSchema.Columns.FirstName];  
            student.LastName = detail[TextFileReaderSchema.Columns.LastName];

            return student;
        }

    }
}