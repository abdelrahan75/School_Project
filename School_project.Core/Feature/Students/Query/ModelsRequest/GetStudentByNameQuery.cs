using MediatR;
using School_project.Core.Feature.Students.Query.ModelResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Feature.Students.Query.ModelsRequest
{
    public class GetStudentByNameQuery : IRequest<Basis.Response<GetStudentByNameModel>>
    {
        public string Name { get; set; }

        public GetStudentByNameQuery(string name)
        {
            Name = name;
        }
    }
}
