using School_project.Domain.Entites;
using School_project.Infrastructure.Abstract;
using School_project.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_project.Infrastructure;
using School_project.Domain;
using Microsoft.EntityFrameworkCore;
using School_project.Infrastructure.InfrastructureBasis;

namespace School_project.Infrastructure.Repositery
{
    public class StudentRepositery : GenericRepositoryAsync<Student>, IStudentRepositery
    {
      
    private readonly DbSet<Student>Dbstudent;

        public StudentRepositery(SchoolDbContext context) : base(context) 
        {
            Dbstudent = context.Set<Student>();
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
          return await Dbstudent.Include(D => D.Department).ToListAsync();
        }

        public async Task<Student> GetStudentByName(string name)
        {
            return  Dbstudent.FirstOrDefault(D => D.Name == name);
        }


    }
}
