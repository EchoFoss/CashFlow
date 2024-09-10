using CashFlow.Application.UseCase.Expense.Register;
using CashFlow.Communication.Request;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Test.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Succsess()
    {
        var validator = new RegisterExpenseValidator();

        var req = RequestRegisterExpenseJsonBuilder.New();
        
        var result = validator.Validate(req);
        result.IsValid.Should().BeTrue();
    }
}