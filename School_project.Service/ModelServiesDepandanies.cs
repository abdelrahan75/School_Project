using Microsoft.Extensions.DependencyInjection;
using School_project.Service.Abstract;
using School_project.Service.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Service
{
    public static class ModelServiesDepandanies
    {
        public static IServiceCollection AddServiesDepandanies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
