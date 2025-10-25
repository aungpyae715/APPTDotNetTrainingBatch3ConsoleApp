using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        public Student()
        {
            StudentName = string.Empty;
            FatherName = string.Empty;


        }
        public int StudentNo;
        public string StudentName;
        public string FatherName;

        public DateTime DateofBirth { get; set; }
    }
}
