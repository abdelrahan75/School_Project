using School_project.Core.Feature.Students.Query.ModelResponse;
using School_project.Core.Feature.Students.Query.Response;
using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Mapping.StudentMapping
{
    public partial class  StudentProfile
    {

        public void GetStudentByIdMapping()
        {
            CreateMap<Student, GetStudentByIdModel>()
                .ForMember(dist => dist.DepartmentName, opti => opti.MapFrom(src => src.Department.DName));
        }
    }
}
