using School_project.Domain.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core.Feature.Students.Query.Response
{
    public class GetStudentListModel
    {

        public int StudID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }     
        public string? DepartmentName { get; set; }

       
    }
}
