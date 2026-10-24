using MediatR;
using School_project.Core.Basis;
using School_project.Core.Feature.Students.Commend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_project.Service;
using School_project.Service.Implement;
using School_project.Service.Abstract;
using AutoMapper;
using School_project.Domain.Entites;

namespace School_project.Core.Feature.Students.Commend.Handler
{
    public class StudentHandlerCommend : ResponseHandler,
         IRequestHandler<AddStudentModel, Basis.Response<string>>
    {
        #region Fields
        private readonly IStudentService studentService;
        private readonly IMapper mapper;
        #endregion

        #region Cons
        public StudentHandlerCommend(IStudentService studentService, IMapper mapper)
        {
            this.studentService = studentService;
            this.mapper = mapper;
        }
        #endregion
        public async Task<Response<string>> Handle(AddStudentModel request, CancellationToken cancellationToken)
        {
            //Service wait a student not request so we mapping reqest in student 
            var StudentRes = mapper.Map<Student>(request);
            //Add
            var Result = await studentService.AddAsync(StudentRes);
            //check Result Response

            if (Result == "Exist") return UnprocessableEntity<string>("name not found");

            else if (Result == "Success") return Created("Added Successfully");
            else return BadRequest<string>();
            
        }
    }
}
