using Microsoft.Extensions.DependencyInjection;
using School_project.Service.Abstract;
using School_project.Service.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace School_project.Core
{
    public static class ModelCoreDepandancies
    {
        public static IServiceCollection AddCoreDepandancies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
