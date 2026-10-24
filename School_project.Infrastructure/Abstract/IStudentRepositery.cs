using School_project.Domain.Entites;
using School_project.Infrastructure.InfrastructureBasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Infrastructure.Abstract
{
    public interface IStudentRepositery : IGenericRepositoryAsync<Student>
    {
        public  Task<List<Student>> GetStudentsAsync();

        public Task<Student> GetStudentByName(string name);
    }

   
}
