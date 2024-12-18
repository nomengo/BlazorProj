using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class UpdateAttributeCommandHandler
    {
        private readonly IAttributeRepository _attributeRepository;

        public UpdateAttributeCommandHandler(IAttributeRepository attributeRepository)
        {
            _attributeRepository = attributeRepository;
        }

        public async Task Handle(UpdateAttributeCommand command)
        {
            var attribute = await _attributeRepository.GetByIdAsync(command.Id);

            if (attribute == null)
            {
                throw new ArgumentException("Attribute not found.");
            }

            attribute.Key = command.Key;
            attribute.Value = command.Value;

            await _attributeRepository.UpdateAsync(attribute);
        }
    }
}
