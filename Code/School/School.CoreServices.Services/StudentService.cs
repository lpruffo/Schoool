using School.CoreServices.Domain;

using School.Utils.Persistance;
using System;

namespace School.CoreServices.Services
{
    public class StudentService : IPersistance<Student>
    {
        public Student Create(Student item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student[] Read(string[] fields, string[] values)
        {
            throw new NotImplementedException();
        }

        public Student ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
