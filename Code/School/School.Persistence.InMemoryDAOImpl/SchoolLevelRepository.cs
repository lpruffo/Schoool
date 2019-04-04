using School.CoreServices.DAO;
using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Persistence.InMemoryDAOImpl
{
    public class SchoolLevelRepository : ISchoolLevelRepository
    {
        public SchoolLevel CreateSchoolLevel(SchoolLevel schoolLevel)
        {
            if (SchoolLevelInMemory.AddSchoolLevel(schoolLevel))
            {
                return schoolLevel;
            }
            else
            {
                return null;
            }
        }

        public SchoolLevel DeleteSchoolLevel(SchoolLevel schoolLevel)
        {
            throw new NotImplementedException();
        }

        public List<SchoolLevel> ReadSchoolLevel(string[] fields, string[] values)
        {
            string id = string.Empty;            

            for (int i = 0; i < fields.Length; i++)
            {
                switch (fields[i])
                {
                    case "SchoolLevelId":
                        id = values[i];
                        break;                    
                    default:
                        break;
                }
            }
            return SchoolLevelInMemory.ReadSchoolLevel(id);
        }

        public SchoolLevel UpdateSchoolLevel(SchoolLevel schoolLevel)
        {
            throw new NotImplementedException();
        }
    }
}
