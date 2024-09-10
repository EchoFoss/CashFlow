namespace CashFlow.Communication.Response;

public class ResponseErrorJson(string[] errorMessages)
{
    public string[] ErrorMessage { get; set; } = errorMessages;

    public ResponseErrorJson(string message) : this(new[] { message }) {}
}