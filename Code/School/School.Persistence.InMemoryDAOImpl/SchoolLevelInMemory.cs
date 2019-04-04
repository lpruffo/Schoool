using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Persistence.InMemoryDAOImpl
{
    public sealed class SchoolLevelInMemory
    {
        private static readonly Lazy<SchoolLevelInMemory> lazy =
        new Lazy<SchoolLevelInMemory>(() => new SchoolLevelInMemory());

        public static SchoolLevelInMemory Instance
        {
            get { return lazy.Value; }
        }

        private static Dictionary<int, SchoolLevel> schoolData = new Dictionary<int, SchoolLevel>();

        private SchoolLevelInMemory()
        {
            schoolData.Add(1, new SchoolLevel { Id = "Kinder", Descpription = "" });
            schoolData.Add(2, new SchoolLevel { Id = "Elementary", Descpription = "" });
            schoolData.Add(3, new SchoolLevel { Id = "High", Descpription = "" });
            schoolData.Add(4, new SchoolLevel { Id = "University", Descpription = "" });
        }        

        private static int GetNewId()
        {
            if (schoolData.Count > 0)
            {
                return schoolData.Count + 1;
            }
            return 1;
        }

        public static bool AddSchoolLevel(SchoolLevel schoolLevel)
        {
            bool result = false;
            try
            {
                schoolData.Add(GetNewId(), schoolLevel);
                result = true;
            }
            finally
            { }

            return result;
        }

        public static List<SchoolLevel> ReadSchoolLevel(string id)
        {

            IEnumerable<SchoolLevel> tempSearch = (from schoolLevel in schoolData.Values
                                               where (id != string.Empty ? schoolLevel.Id.ToLower() == id.ToLower() : true)                                               
                                               select schoolLevel
                                               );
            return tempSearch.ToList();
        }
    }
}
