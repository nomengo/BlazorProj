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
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<ISalaryRepository, SalaryRepository>();


            //Department
            services.AddScoped<CreateDepartmentCommandHandler>();

            services.AddScoped<GetAllDepartmentsQueryHandler>();


            //Project
            services.AddScoped<CreateProjectCommandHandler>();
            services.AddScoped<AssignEmployeesToProjectCommandHandler>();
            services.AddScoped<UnassignEmployeesFromProjectCommandHandler>();

            services.AddScoped<GetAllProjectsQueryHandler>();
            services.AddScoped<GetProjectDetailsQueryHandler>();


            //Employee
            services.AddScoped<CreateEmployeeCommandHandler>();
            services.AddScoped<UpdateEmployeeCommandHandler>();
            services.AddScoped<DeleteEmployeeCommandHandler>();

            services.AddScoped<GetAllEmployeesQueryHandler>();
            services.AddScoped<GetEmployeeByIdQueryHandler>();


            //Tasks
            services.AddScoped<CreateTasksCommandHandler>();

            services.AddScoped<GetAllTasksQueryHandler>();


            //Attendance
            services.AddScoped<AddAttendanceCommandHandler>();
            services.AddScoped<UpdateAttendanceCommandHandler>();

            services.AddScoped<GetAttendanceByEmployeeIdQueryHandler>();


            //Salary
            services.AddScoped<AddSalaryCommandHandler>();
            services.AddScoped<UpdateSalaryCommandHandler>();

            services.AddScoped<GetSalariesByEmployeeIdQueryHandler>();

            return services;
        }
    }
}
