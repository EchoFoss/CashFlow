using CashFlow.Application.UseCase.Expense.Register;
using CashFlow.Communication.Request;
using CashFlow.Communication.Response;
using CashFlow.Exception.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[ProducesResponseType(StatusCodes.Status201Created)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RegisterExpenseReq req)
    {
        var useCase = new RegisterExpenseUseCase();
        
        var response = useCase.Execute(req);
        return Created(string.Empty, response);
    }
}