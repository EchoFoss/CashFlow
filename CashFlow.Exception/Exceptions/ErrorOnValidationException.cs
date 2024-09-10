namespace CashFlow.Exception.Exceptions;

public class ErrorOnValidationException(string[] errs) : CashFlowException
{
    public string[] Errors { get; set; } = errs;
}