using App.Services.Contracts;
using App.Services.Features.AdminService.Queries.GetById;

namespace App.Services.Features.AdminService;

public class AdminService : IAdminService
{
    public Task<AdminQuery> GetById(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
