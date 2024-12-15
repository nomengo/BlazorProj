using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using BlazorStajApplication.Infrastructure.Persistence;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class DeleteEmployeeCommandHandler
    {
        private readonly IEmployeeRepository _repository;
        //private readonly ITasksRepository _taskRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository repository  /*ITasksRepository taskRepository*/)
        {
            _repository = repository;
           // _taskRepository = taskRepository;
        }

        public async Task Handle(DeleteEmployeeCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
