using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using School_project.Domain.Entites;

namespace School_project.Infrastructure.Data
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Subjects> Subjects { get; set; }

        public DbSet<StudentSubject> StudentSubjects { get; set; }

 public DbSet<DepartmetSubject> departmetSubjects { get; set; }
    }
}
