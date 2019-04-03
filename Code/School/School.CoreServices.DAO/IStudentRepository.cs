
using School.CoreServices.Domain;
using System.Collections.Generic;

namespace School.CoreServices.DAO
{
    public interface IStudentRepository
    {
        Student CreateStudent(Student student);
                
        List<Student> ReadStudent(string name);

        Student UpdateStudent(Student plane);

        Student DeleteStudent(Student plane);
    }
}
