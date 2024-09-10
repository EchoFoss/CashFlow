using CashFlow.Communication.Request;
using CashFlow.Communication.Response;
using CashFlow.Exception.Exceptions;

namespace CashFlow.Application.UseCase.Expense.Register;

public class RegisterExpenseUseCase
{
    public RegisterExpenseResp Execute(RegisterExpenseReq req)
    {
        try
        {
            Validate(req);
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return new RegisterExpenseResp();
    }

    private void Validate(RegisterExpenseReq req)
    {
        var validator = new RegisterExpenseValidator();
        var validationResult = validator.Validate(req);
        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors.Select(x => x.ErrorMessage).ToArray();
            throw new ErrorOnValidationException(errors);

        }
    }
}