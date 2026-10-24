using School_project.Core.Feature.Students.Commend.Models;
using School_project.Core.Feature.Students.Query.ModelResponse;
using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Mapping.StudentMapping
{
    public partial class StudentProfile
    {
        public void AddStudentCommend()
        {
            CreateMap<AddStudentModel , Student>()
                .ForMember(dist => dist.DID, opti => opti.MapFrom(src => src.DepartmentId));
        }
    }
}
