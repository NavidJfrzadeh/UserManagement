using App.Services.Contracts;
using MediatR;

namespace App.Services.Features.CustomerService.Queries.GetAll
{
    internal class CustomerListQueryHandler(ICustomerRepository _repo) : IRequestHandler<CustomerListQuery, List<CustomerListQuery>>
    {
        public async Task<List<CustomerListQuery>> Handle(CustomerListQuery request, CancellationToken cancellationToken)
        {
            var CustomerList = await _repo.GetAll(cancellationToken);
            List<CustomerListQuery> list = (List<CustomerListQuery>)CustomerList.Select(c => new CustomerListQuery());
            return list;
        }
    }
}
