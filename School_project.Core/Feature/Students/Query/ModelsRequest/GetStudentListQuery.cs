using Azure.Core;
using MediatR;
using School_project.Core.Basis;
using School_project.Core.Feature.Students.Query.Response;
using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Feature.Students.Query.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListModel>>>
    {
    }
}
