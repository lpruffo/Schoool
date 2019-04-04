using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.CoreServices.DAO
{
    public interface ISchoolLevelRepository
    {
        SchoolLevel CreateSchoolLevel(SchoolLevel schoolLevel);

        List<SchoolLevel> ReadSchoolLevel(string[] fields, string[] values);

        SchoolLevel UpdateSchoolLevel(SchoolLevel schoolLevel);

        SchoolLevel DeleteSchoolLevel(SchoolLevel schoolLevel);
    }
}
