using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Persistence.InMemoryDAOImpl
{
    public sealed class InMemory
    {
        private static readonly Lazy<InMemory> lazy =
        new Lazy<InMemory>(() => new InMemory());

        public static InMemory Instance
        {
            get { return lazy.Value; }
        }

        private InMemory()
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

        public static List<Student> ReadStudent( string Name )
        {
            IEnumerable<Student> tempSearch = (from student in StudentData.Values
                                               where (Name != null ? student.Name == Name : true)
                                               select student
                                               );
            return tempSearch.ToList();
        }
    }
}
