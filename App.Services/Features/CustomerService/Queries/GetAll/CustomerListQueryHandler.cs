using App.Core;
using App.Services.Contracts;
using FluentValidation;
using MediatR;

namespace App.Services.Features.CustomerService.Queries.GetAll;

internal class CustomerListQueryHandler(ICustomerService _service
    , IValidator<CustomerListQuery> validator
    , SiteSettings siteSettings) : IRequestHandler<CustomerListQuery, List<CustomerListQuery>>
{
    public async Task<List<CustomerListQuery>> Handle(CustomerListQuery request, CancellationToken cancellationToken)
    {
        validator.Validate(request);
        return await _service.GetAllInPage(request.pageNumber, siteSettings.PageSize, cancellationToken);
    }
}
