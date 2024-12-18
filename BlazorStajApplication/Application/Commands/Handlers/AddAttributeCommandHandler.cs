using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class AddAttributeCommandHandler
    {
        private readonly IAttributeRepository _attributeRepository;

        public AddAttributeCommandHandler(IAttributeRepository attributeRepository)
        {
            _attributeRepository = attributeRepository;
        }

        public async Task Handle(AddAttributeCommand command)
        {
            var attribute = new EmployeeAttribute
            {
                EmployeeId = command.EmployeeId,
                Key = command.Key,
                Value = command.Value
            };

            await _attributeRepository.AddAsync(attribute);
        }
    }
}
