using App.Core.CustomerEntity;
using App.Services.Contracts;
using App.Services.Features.CustomerService.Commands.Create;

namespace App.Services.Features.CustomerService;

public class CustomerService(ICustomerRepository _repo) : ICustomerService
{
    public async Task<int> Create(CreateCustomerCommand createCustomerCommand)
    {
        var newCustomer = new Customer(createCustomerCommand.FullName, createCustomerCommand.Email);
        return await _repo.Create(newCustomer);
    }
}
