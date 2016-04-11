using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirstEF.Entity;
using System.Data.Entity;

namespace CodeFirstEF.DataContext
{
    class Context:DbContext
    {
        public Context()
            : base()
        {
        }

        public List<Student> Students { get; set; }
        public List<Standard> Standards { get; set; }

    }
}
