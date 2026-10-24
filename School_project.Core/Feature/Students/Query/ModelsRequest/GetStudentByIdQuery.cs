using Azure;
using MediatR;
using School_project.Core.Basis;
using School_project.Core.Feature.Students.Query.ModelResponse;
using School_project.Core.Feature.Students.Query.Response;
using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Feature.Students.Query.ModelsRequest
{
    public class GetStudentByIdQuery : IRequest<Basis.Response<GetStudentByIdModel>>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
