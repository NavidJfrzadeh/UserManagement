using App.Services.Contracts.DTOs;

namespace App.Services.Contracts;

public interface IAdminRepository
{
    Task<CustomerDto> GetById(int id, CancellationToken cancellationToken);
}
