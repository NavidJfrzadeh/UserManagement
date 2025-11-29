using App.Core.CustomerEntity;
using App.Services.Contracts;
using App.Services.Features.CustomerService.Commands.Create;
using App.Services.Features.CustomerService.Queries.GetAll;

namespace App.Services.Features.CustomerService;

public class CustomerService(ICustomerRepository _repo) : ICustomerService
{
    public async Task<int> Create(CreateCustomerCommand createCustomerCommand)
    {
        var newCustomer = new Customer(createCustomerCommand.FullName, createCustomerCommand.Email);
        return await _repo.Create(newCustomer);
    }

    public async Task<List<CustomerListQuery>> GetAllInPage(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        var customers = await _repo.GetAllInPage(pageNumber, pageSize, cancellationToken);
        if (customers.Any())
            return customers;
        throw new Exception("no Customers found");
    }
}
