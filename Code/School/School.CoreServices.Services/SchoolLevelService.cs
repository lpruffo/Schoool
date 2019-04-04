using School.CoreServices.DAO;
using School.CoreServices.Domain;
using School.Persistence.InMemoryDAOImpl;
using School.Utils.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.CoreServices.Services
{
    public class SchoolLevelService : IPersistance<SchoolLevel>
    {
        ISchoolLevelRepository schoolLevelRepository;

        public SchoolLevelService()
        {
            schoolLevelRepository = new SchoolLevelRepository();
        }

        public SchoolLevel Create(SchoolLevel item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SchoolLevel> Read(string[] fields, string[] values)
        {
            return schoolLevelRepository.ReadSchoolLevel(fields, values);
        }

        public SchoolLevel ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public SchoolLevel Update(SchoolLevel item)
        {
            throw new NotImplementedException();
        }
    }
}
