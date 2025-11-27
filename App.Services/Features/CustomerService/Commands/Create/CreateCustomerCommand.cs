using MediatR;

namespace App.Services.Features.CustomerService.Commands.Create;

public record CreateCustomerCommand(string FullName,string Email): IRequest<int>;