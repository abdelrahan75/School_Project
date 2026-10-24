
using Microsoft.EntityFrameworkCore;
using School_project.Infrastructure.Data;
using School_project.Infrastructure;
using School_project.Infrastructure.Abstract;
using School_project.Infrastructure.Repositery;
using School_project.Service;
using School_project.Core;

namespace Task_And_Habit_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Sc")));

            builder.Services.AddInfrastructureDependancies()
                .AddServiesDepandanies()
                .AddCoreDepandancies();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
