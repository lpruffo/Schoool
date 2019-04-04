using School.CoreServices.DAO;
using School.CoreServices.Domain;
using School.Persistence.InMemoryDAOImpl;
using School.Utils.Persistance;
using System;
using System.Collections.Generic;

namespace School.CoreServices.Services
{
    public class StudentService : IPersistance<Student>
    {
        IStudentRepository studentRepository;

        public StudentService()
        {
            studentRepository = new StudentRepository();
        }

        public Student Create(Student item)
        {
            if (ValidateStudent(item))
            {
                studentRepository.CreateStudent(item);
                return item;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Read(string[] fields, string[] values)
        {            
             return studentRepository.ReadStudent(fields,values);            
        }

        public Student ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student item)
        {
            throw new NotImplementedException();
        }

        private bool ValidateStudent(Student stundent)
        {
            return stundent.SchoolLevelID != string.Empty ||
                    stundent.Name != string.Empty ||
                    stundent.Gender != gender.E ||
                    stundent.LastModificaction != null;
        }
            
    }
}
