using App.MVC.Models;
using App.Services.Features.CustomerService.Commands.Create;
using App.Services.Features.CustomerService.Queries.GetAll;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.MVC.Controllers;

public class AdminController(IMediator _mediator) : Controller
{
    [HttpGet("[action]/{pageNumber:int}")]
    public async Task<IActionResult> GetAllCustomers(int pageNumber = 1, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new CustomerListQuery(), cancellationToken);
        return View(customers);
    }

    public IActionResult CreateCustomer()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer(CustomerCreateViewModel model, CancellationToken cancellationToken)
    {
        try
        {
            var customerCommand = new CreateCustomerCommand(model.FullName, model.Email);
            await _mediator.Send(customerCommand, cancellationToken);
            TempData["CreateSuccess"] = "با موفقیت ساخته شد";
            return View();
        }
        catch (ValidationException ex)
        {
            ModelState.Clear();
            foreach (var error in ex.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(model);
        }

    }
}
