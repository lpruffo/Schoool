using School.CoreServices.Domain;
using School.CoreServices.Services;
using School.Utils.CSV;
using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            List<Student> students;
            if (args.Length == 1)
            {
                students = CSVHelper.ReadCSVfromFile(args[0]);
                foreach (var student in students)
                {
                    var a = studentService.Create(student);
                }                
            }
            else
            {
                string[] fields = new string[args.Length-1];
                string[] values = new string[args.Length - 1];
                for (int i = 1; i < args.Length; i++)
                {
                    int pos = args[i].IndexOf("=");
                    fields[i - 1] = args[i].Substring(0, pos);
                    values[i - 1] = args[i].Substring(pos+1);
                }
                students = studentService.Read(fields, values);

                foreach (var student in students)
                {
                    Console.WriteLine(student.SchoolLevelID, student.Name, student.Gender, student.LastModificaction);
                }
            }
        }
    }
}
