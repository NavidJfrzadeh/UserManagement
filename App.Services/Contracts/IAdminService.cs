using App.Services.Features.AdminService.Queries.GetById;

namespace App.Services.Contracts;

public interface IAdminService
{
    Task<AdminQuery> GetById(int id, CancellationToken cancellationToken);
}