using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirstEF.Entity;
using CodeFirstEF.DataContext;
using System.Configuration;
using System.Data;

namespace CodeFirstEF
{
    class Manager
    {
        Context context = new Context();
        public void SetUp()
        {
           // string conString = ConfigurationSettings.AppSettings["SchoolDBConnectionString"];
            
            //context.Students.Add(new Student { StudentID = 1, StudentName = "A" });
           // context.SaveChanges();
        }

        public IEnumerable<string> Read()
        {
            var t = context.Students.ToList()[0];
            t.StudentName="b";
            context.Entry(t).State=EntityState.Modified;
            context.SaveChanges();
            //EntityState.
            // string conString = ConfigurationSettings.AppSettings["SchoolDBConnectionString"];

            var e= from a in context.Students
                   select a.StudentName;
            return e;
 
        }


    }
}
