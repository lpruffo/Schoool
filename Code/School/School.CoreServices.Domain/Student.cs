using System;
using System.Collections.Generic;
using System.Text;

namespace School.CoreServices.Domain
{
    public class Student : Person
    {
        public string SchoolLevelID { get; set; }
        public string LastModificaction { get; set; }

        public Student() { }
    }
}
