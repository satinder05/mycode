using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstEF.Entity
{
    public class Student
    {
        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }
    }
}
