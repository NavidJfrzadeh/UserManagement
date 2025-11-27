using App.Core.CustomerEntity;
using App.Services.Contracts.DTOs;

namespace App.Services.Contracts;

public interface ICustomerRepository
{
    Task<CustomerDto> GetById(int id, CancellationToken cancellationToken);
    Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken);
    Task<int> Create(Customer customer);
    Task Update(CustomerCreateDto customer);
    Task Delete(int id);
}
