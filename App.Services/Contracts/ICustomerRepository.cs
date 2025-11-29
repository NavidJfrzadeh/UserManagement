using App.Core.CustomerEntity;
using App.Services.Features.CustomerService.Commands.Update;
using App.Services.Features.CustomerService.Queries.GetAll;
using App.Services.Features.CustomerService.Queries.GetById;

namespace App.Services.Contracts;

public interface ICustomerRepository
{
    Task<CustomerQuery> GetById(int id, CancellationToken cancellationToken);
    Task<List<CustomerListQuery>> GetAllInPage(int pageNumber, int pageSize, CancellationToken cancellationToken);
    Task<int> Create(Customer customer);
    Task Update(CustomerUpdateCommand customer);
    Task Delete(int id);
}
