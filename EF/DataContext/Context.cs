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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, EF.Migrations.Configuration>());
            //Students = new List<Student>();
            //Standards = new List<Standard>();
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
