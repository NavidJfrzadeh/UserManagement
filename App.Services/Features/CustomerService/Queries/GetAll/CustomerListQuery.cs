using MediatR;

namespace App.Services.Features.CustomerService.Queries.GetAll;

public record CustomerListQuery(int id = 0, string fullName = "", string email = "", int pageNumber = 1) : IRequest<List<CustomerListQuery>>;
