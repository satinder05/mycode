using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirstEF.Entity;
using CodeFirstEF.DataContext;

namespace CodeFirstEF
{
    class Manager
    {
        public static void SetUp()
        {
            Context context = new Context();
            context.Students.Add(new Student { StudentID = 1, StudentName = "A" });
            context.SaveChanges();
        }
    }
}
