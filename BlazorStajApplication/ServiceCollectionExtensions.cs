using BlazorStajApplication.Application.Commands.Handlers;
using BlazorStajApplication.Application.Queries.Handlers;
using BlazorStajApplication.Domain.Repositories;
using BlazorStajApplication.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorStajApplication
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ITasksRepository, TasksRepository>();


            services.AddScoped<CreateDepartmentCommandHandler>();

            services.AddScoped<CreateEmployeeCommandHandler>();
            services.AddScoped<UpdateEmployeeCommandHandler>();
            services.AddScoped<DeleteEmployeeCommandHandler>();

            services.AddScoped<CreateTasksCommandHandler>();


            services.AddScoped<GetAllDepartmentsQueryHandler>();

            services.AddScoped<GetAllEmployeesQueryHandler>();
            services.AddScoped<GetEmployeeByIdQueryHandler>();

            services.AddScoped<GetAllTasksQueryHandler>();


            return services;
        }
    }
}
