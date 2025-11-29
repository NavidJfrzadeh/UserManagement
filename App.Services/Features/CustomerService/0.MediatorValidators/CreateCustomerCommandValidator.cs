using App.Services.Features.CustomerService.Commands.Create;
using FluentValidation;

namespace App.Services.Features.CustomerService.MediatorValidators;

public sealed class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(c => c.FullName)
            .NotEmpty().WithMessage("نام مشتری نباید خالی باشد!")
            .MaximumLength(300).WithMessage("نام باید کم تر از 300 حرف باشد");

        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("ایمیل نباید خالی باشد!")
            .EmailAddress().WithMessage("آدرس ایمیل باید معتبر باشد")
            .MaximumLength(100).WithMessage("ایمیل ادرس باید کم تر از 100 حرف باشد");
    }
}
