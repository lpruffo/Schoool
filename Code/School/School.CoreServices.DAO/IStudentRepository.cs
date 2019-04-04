
using School.CoreServices.Domain;
using System.Collections.Generic;

namespace School.CoreServices.DAO
{
    public interface IStudentRepository
    {
        Student CreateStudent(Student student);

        List<Student> ReadStudent(string[] fields, string[] values);

        Student UpdateStudent(Student student);

        Student DeleteStudent(Student student);
    }
}
