using App.Services.Features.CustomerService.Commands.Create;

namespace App.Services.Contracts
{
    public interface ICustomerService
    {
        Task<int> Create(CreateCustomerCommand createCustomerCommand);
    }
}