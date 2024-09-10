using CashFlow.Communication.Request;
using FluentValidation;

namespace CashFlow.Application.UseCase.Expense.Register;

public class RegisterExpenseValidator : AbstractValidator<RegisterExpenseReq>
{
    public RegisterExpenseValidator()
    {
        RuleFor(exp => exp.Title).
            NotEmpty().
            WithMessage("The title is required.");
        
        RuleFor(exp => exp.Amount).
            GreaterThan(0).
            WithMessage("The amount must be greater than zero.");
        
        RuleFor(x => x.Date).
            LessThanOrEqualTo(DateTime.UtcNow).
            WithMessage("The date must be greater than or equal to current date.");
        
        RuleFor(x => x.PaymentType).
            IsInEnum().
            WithMessage("The payment type is invalid.");
    }
    
}