using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Persistence.InMemoryDAOImpl
{
    public sealed class StudentInMemory
    {
        private static readonly Lazy<StudentInMemory> lazy =
        new Lazy<StudentInMemory>(() => new StudentInMemory());

        public static StudentInMemory Instance
        {
            get { return lazy.Value; }
        }

        private StudentInMemory()
        {
        }

        private static Dictionary<int, Student> StudentData = new Dictionary<int, Student>();

        private static int GetNewId()
        {
            if (StudentData.Count > 0)
            {
                return StudentData.Count + 1;
            }
            return 1;
        }

        public static bool AddStudent (Student student)
        {
            bool result = false;
            try
            {
                int id = GetNewId();
                student.ID = id.ToString();
                StudentData.Add(id, student);
                result = true;
            }
            finally
            { }

            return result;
            
        }

        public static List<Student> ReadStudent(string schoolLevelId, string name, gender? gender, string lastModification)
        {

            IEnumerable<Student> tempSearch = (from student in StudentData.Values
                                               where (schoolLevelId != string.Empty ? student.SchoolLevelID == schoolLevelId : true) &&
                                               (name != string.Empty ? student.Name.ToLower() == name.ToLower() : true) &&
                                               (gender != null ? student.Gender == gender : true) &&
                                               (lastModification != string.Empty ? student.LastModificaction == lastModification : true) 
                                               select student
                                               );
            return tempSearch.ToList();
        }
    }
}
