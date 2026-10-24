using Microsoft.Extensions.DependencyInjection;
using School_project.Infrastructure.Abstract;
using School_project.Infrastructure.InfrastructureBasis;
using School_project.Infrastructure.Repositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Infrastructure
{
    public static class ModelInfrastructureDependancies
    {
        public static IServiceCollection AddInfrastructureDependancies( this IServiceCollection services)
        {
            services.AddTransient<IStudentRepositery, StudentRepositery>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
