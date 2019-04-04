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
            if (StudentInMemory.AddStudent(student))
            {
                return student;
            }
            else
            {
                return null;
            }
        }

        public Student DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> ReadStudent (string[] fields, string[] values)
        {
            string schoolLevelId = string.Empty;
            string name = string.Empty;
            gender? genderl = null;
            string lastModification = string.Empty;

            for (int i = 0; i < fields.Length; i++)
            {
                switch (fields[i])
                {
                    case "SchoolLevelId":
                        schoolLevelId = values[i];
                        break;
                    case "Name":
                        name = values[i];
                        break;
                    case "Gender":
                        genderl = values[i] == "F" ? gender.F : values[i] == "M" ? gender.M : gender.E;
                        genderl = genderl == gender.E ? null: genderl ;
                        break;
                    case "LastModification":
                        lastModification = values[i];
                        break;
                    default:
                        break;
                }
            }
            return StudentInMemory.ReadStudent( schoolLevelId,name,genderl,lastModification );
            
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
