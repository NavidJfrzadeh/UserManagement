using MediatR;

namespace App.Services.Features.CustomerService.Commands.Delete;

public record DeleteCustomerCommand(int id) : IRequest<bool>;
