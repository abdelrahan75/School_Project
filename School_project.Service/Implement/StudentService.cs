using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens.Experimental;
using School_project.Domain.Entites;
using School_project.Infrastructure.Abstract;
using School_project.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Service.Implement
{
    public class  StudentService : IStudentService
    {
        private readonly IStudentRepositery studentrepositery;
        public StudentService(IStudentRepositery repositery1)
        {
           this.studentrepositery = repositery1; 
        }
        public  async Task<List<Student>> GetStudentsAsync()
        {
            return await studentrepositery.GetStudentsAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
           var Student =   studentrepositery.GetTableNoTracking()
                                          .Include(x=>x.Department)
                                          .Where (x=> x.StudID == id)
                                          .FirstOrDefault();
            return  Student;
        }

        public async Task<Student> GetStudentByNameAsync(string name)
        {
            var student = studentrepositery.GetTableNoTracking()
                                            .Include(x=>x.Department)
                                            .Where(x=> x.Name == name)
                                            .FirstOrDefault();
            return student;
        }

        public async Task<string>AddAsync(Student student)
        {
            // check on name or id or anything in Core layer


            //
            var StudentRes = studentrepositery.GetTableNoTracking()
                .Where(x => x.Name.Equals(student.Name))
                .FirstOrDefault();

            if (StudentRes == null) return "Exist";

           await studentrepositery.AddAsync(student);
            return "Success";


        }
    }
}
