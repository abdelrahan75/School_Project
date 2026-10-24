using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();

        public Task<Student> GetStudentByIdAsync(int id);

        public Task<Student> GetStudentByNameAsync(string name);

        public Task<string> AddAsync(Student student);
    }
}
