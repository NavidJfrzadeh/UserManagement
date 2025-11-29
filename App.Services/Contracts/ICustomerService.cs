using App.Services.Features.CustomerService.Commands.Create;
using App.Services.Features.CustomerService.Queries.GetAll;

namespace App.Services.Contracts
{
    public interface ICustomerService
    {
        Task<int> Create(CreateCustomerCommand createCustomerCommand);
        Task<List<CustomerListQuery>> GetAllInPage(int pageNumber, int pageSize, CancellationToken cancellationToken);
    }
}