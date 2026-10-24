using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_project.Core;

namespace School_project.Core.Mapping.StudentMapping
{
    public partial class StudentProfile: Profile
    {
        public StudentProfile()
        {
            GetstudentListMapping();
            GetStudentByIdMapping();
            GetStudentByNameMapping();
            AddStudentCommend();


        }
    }
}
