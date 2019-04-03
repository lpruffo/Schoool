using School.CoreServices.DAO;
using School.CoreServices.Domain;
using System;
using System.Collections.Generic;

namespace School.Persistence.InMemoryDAOImpl
{
    public class StudentRepository : IStudentRepository
    {
        public Student CreateStudent(Student student)
        {
            if (InMemory.AddStudent(student))
            {
                return student;
            }
            else
            {
                return null;
            }
        }

        public Student DeleteStudent(Student plane)
        {
            throw new NotImplementedException();
        }

        public List<Student> ReadStudent(string name)
        {
            return InMemory.ReadStudent(name);
        }

        public Student UpdateStudent(Student plane)
        {
            throw new NotImplementedException();
        }
    }
}
