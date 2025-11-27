using MediatR;

namespace App.Services.Features.CustomerService.Commands.Delete;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
{
    public Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
