using System;

namespace School.CoreServices.Domain
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public gender Gender { get; set; }
    }
}
