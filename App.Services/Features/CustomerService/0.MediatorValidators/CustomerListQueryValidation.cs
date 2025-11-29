using App.Services.Features.CustomerService.Queries.GetAll;
using FluentValidation;

namespace App.Services.Features.CustomerService._0.MediatorValidators;

public class CustomerListQueryValidation : AbstractValidator<CustomerListQuery>
{
    public CustomerListQueryValidation()
    {
        RuleFor(c => c.pageNumber)
            .GreaterThanOrEqualTo(1).WithMessage("شماره صفحه باید بیشتر از 1 باشد");
    }
}
