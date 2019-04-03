using School.CoreServices.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace School.Utils.CSV
{
    sealed class CSVHelper
    {
        private static readonly Lazy<CSVHelper> csvHelperInstance = new Lazy<CSVHelper>(() => new CSVHelper());
        private CSVHelper() { }
        public static CSVHelper CsvHelperInstance
        {
            get { return csvHelperInstance.Value; }
        }

        public static List<Student> ReadCSVfromFile (string fileName)
        {
            var csvlines = File.ReadAllLines(fileName); 
            var students = csvlines.Select(l => l.Split(','))
                    .Skip(1)
                    .Select(data => new Student
                    {
                        SchoolLevelID = data[0],
                        Name = data[1],
                        Gender = data[2]=="M"? gender.M: (data[2] == "F" ? gender.F: gender.E ) ,
                        LastModificaction = GetDateFromSCVString(data[3])
                    })
                    .ToList();
            return students;
        }

        private static DateTime GetDateFromSCVString(string date)
        {
            if (date != String.Empty)
            {
                return new DateTime(
                    Convert.ToInt32(date.Substring(0, 4)),
                    Convert.ToInt32(date.Substring(4, 2)),
                    Convert.ToInt32(date.Substring(6, 2)),
                    Convert.ToInt32(date.Substring(8, 2)),
                    Convert.ToInt32(date.Substring(10, 2)),
                    Convert.ToInt32(date.Substring(12, 2))
                    );
            }
            return DateTime.Now;
        }
    }
}


