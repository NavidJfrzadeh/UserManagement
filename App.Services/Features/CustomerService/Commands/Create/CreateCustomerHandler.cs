using App.Services.Contracts;
using MediatR;

namespace App.Services.Features.CustomerService.Commands.Create;

public class CreateCustomerHandler(ICustomerService _service) : IRequestHandler<CreateCustomerCommand, int>
{
    public async Task<int> Handle(CreateCustomerCommand customerCreateCommand, CancellationToken cancellationToken)
    {
        return await _service.Create(customerCreateCommand);
    }
}
