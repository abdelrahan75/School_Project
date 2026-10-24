using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_project.Core.Basis;

namespace School_project.Core.Feature.Students.Commend.Models
{
    public class AddStudentModel : IRequest<Response<string>>
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string phone { get; set; }
        public int  DepartmentId { get; set; }
    }
}
