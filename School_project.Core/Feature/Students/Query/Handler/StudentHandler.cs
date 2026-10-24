using AutoMapper;
using Azure;
using MediatR;
using School_project.Core.Basis;
using School_project.Core.Feature.Students.Query.ModelResponse;
using School_project.Core.Feature.Students.Query.Models;
using School_project.Core.Feature.Students.Query.ModelsRequest;
using School_project.Core.Feature.Students.Query.Response;
using School_project.Domain.Entites;
using School_project.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Feature.Students.Query.Handler
{
    public class StudentHandler : ResponseHandler,
                                  IRequestHandler<GetStudentListQuery, Basis.Response<List<GetStudentListModel>>>,
                                  IRequestHandler<GetStudentByIdQuery, Basis.Response<GetStudentByIdModel>>,
                                  IRequestHandler<GetStudentByNameQuery, Basis.Response<GetStudentByNameModel>>
                                  
    {
        
    

    private readonly IStudentService service;
        private readonly IMapper Mapper;

        public StudentHandler(IStudentService studentService, IMapper _Mapper)
        {
            service = studentService;
            Mapper = _Mapper;
        }
        public async Task<Basis.Response< List<GetStudentListModel>>>Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var StudentList = await service.GetStudentsAsync();
            var StudentListMapper = Mapper.Map<List<GetStudentListModel>>(StudentList);
            return Success (StudentListMapper);
        }

        public async Task<Basis.Response<GetStudentByIdModel>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var Student = await service.GetStudentByIdAsync(request.Id);

            if (Student == null)
            {
                return NotFound<GetStudentByIdModel>("Not Found");
            }
            var StudentMapper = Mapper.Map<GetStudentByIdModel>(Student);
            return Success (StudentMapper);
        }

        public async Task<Basis.Response<GetStudentByNameModel>> Handle(GetStudentByNameQuery request, CancellationToken cancellationToken)
        {
            var Student = await service.GetStudentByNameAsync(request.Name);

            if (Student == null)
            {
                return NotFound<GetStudentByNameModel>("Name Not Found");
            }
            var StudentMapper = Mapper.Map<GetStudentByNameModel>(Student);
            return Success (StudentMapper);
        }
    }
}
