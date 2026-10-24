using School_project.Core.Feature.Students.Query.Response;
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
        public void GetstudentListMapping()
        {
            CreateMap<Student, GetStudentListModel>()
                .ForMember(dist => dist.DepartmentName, opti => opti.MapFrom(src => src.Department.DName));
        }
    }
}
