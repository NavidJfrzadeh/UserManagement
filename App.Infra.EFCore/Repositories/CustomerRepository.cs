using App.Core.CustomerEntity;
using App.Services.Contracts;
using App.Services.Features.CustomerService.Commands.Update;
using App.Services.Features.CustomerService.Queries.GetAll;
using App.Services.Features.CustomerService.Queries.GetById;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.EFCore.Repositories;

public class CustomerRepository(AppDbContext _context) : ICustomerRepository
{
    public async Task<int> Create(Customer customer)
    {
        _context.Add(customer);
        await _context.SaveChangesAsync();
        return customer.Id;
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CustomerListQuery>> GetAllInPage(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await _context.Customers.Select(c => new CustomerListQuery(c.Id, c.FullName, c.Email))
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
    }

    public Task<CustomerQuery> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    public Task Update(CustomerUpdateCommand customer)
    {
        throw new NotImplementedException();
    }
}
