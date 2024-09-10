using System.Net;
using CashFlow.Communication.Response;
using CashFlow.Exception.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.Api.Filters;

public class ExceptionFIlter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is not CashFlowException)
        {
            ThrowUnknownError(context);
        }
        
        HandleProjectException(context);
    }

    private void HandleProjectException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Errors);
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    private void ThrowUnknownError(ExceptionContext context)
    {
        var errorMessage = new ResponseErrorJson("Unknown Error");
        
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorMessage);
        
    }
}