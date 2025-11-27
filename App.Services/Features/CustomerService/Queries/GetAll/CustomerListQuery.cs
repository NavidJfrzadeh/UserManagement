using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Features.CustomerService.Queries.GetAll
{
    public record CustomerListQuery : IRequest<List<CustomerListQuery>>;
}
