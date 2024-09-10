using CashFlow.Application.UseCase.Expense.Register;
using CashFlow.Communication.Request;

namespace Validators.Test.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Succsess()
    {
        var validator = new RegisterExpenseValidator();

        var req = new RegisterExpenseReq
        {
            Amount = 100,
            Date = DateTime.Now,
            Description = "description",
            Title = "apple",
            PaymentType = PaymentType.Cash,
        };
        
        var result = validator.Validate(req);
        Assert.True(result.IsValid);
    }
}