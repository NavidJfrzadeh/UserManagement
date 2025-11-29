using App.Services.Contracts;
using FluentValidation;
using MediatR;

namespace App.Services.Features.CustomerService.Commands.Create;

public class CreateCustomerHandler(ICustomerService _service
    , IValidator<CreateCustomerCommand> validator) : IRequestHandler<CreateCustomerCommand, int>
{
    public async Task<int> Handle(CreateCustomerCommand customerCreateCommand, CancellationToken cancellationToken)
    {
        validator.ValidateAndThrow(customerCreateCommand);
        return await _service.Create(customerCreateCommand);
    }
}
