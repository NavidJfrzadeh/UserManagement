using App.Core.CustomerEntity;
using App.Services.Contracts;
using App.Services.Contracts.DTOs;
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

    public async Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Customers.Select(c => new CustomerDto
        {
            Id = c.Id,
            Email = c.Email,
            FirstName = c.FullName
        }).ToListAsync(cancellationToken);
    }

    public Task<CustomerDto> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    public Task Update(CustomerCreateDto customer)
    {
        throw new NotImplementedException();
    }
}
