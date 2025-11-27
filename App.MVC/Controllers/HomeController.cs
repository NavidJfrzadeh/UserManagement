using App.MVC.Models;
using App.Services.Features.CustomerService.Commands.Create;
using App.Services.Features.CustomerService.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.MVC.Controllers
{
    public class HomeController(IMediator _mediator) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerCreateViewModel createModel, CancellationToken cancellationToken)
        {
            var customerCommand = new CreateCustomerCommand(createModel.FullName, createModel.Email);
            var id = await _mediator.Send(customerCommand, cancellationToken);
            //return CreateOnAction(id);
            return Ok(id);
        }

        public async Task<IActionResult> GetAllCustomers(CancellationToken cancellationToken)
        {
           var customers = await _mediator.Send(new CustomerListQuery(), cancellationToken);
            return Ok(customers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
