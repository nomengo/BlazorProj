using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAllTasksQueryHandler
    {
        private readonly ITasksRepository _taskRepository;

        public GetAllTasksQueryHandler(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TasksDto>> Handle(GetAllTasksQuery query)
        {
            var tasks = await _taskRepository.GetAllAsync();

            return tasks.Select(t => new TasksDto
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                DueDate = t.DueDate,
                AssignedEmployeeName = $"{t.AssignedEmployee.FirstName} {t.AssignedEmployee.LastName}"
            }).ToList();
        }
    }

    public class TasksDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string AssignedEmployeeName { get; set; }
    }
}
