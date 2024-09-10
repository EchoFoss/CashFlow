namespace CashFlow.Communication.Request;

public class RegisterExpenseReq
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public PaymentType PaymentType { get; set; }
}

public enum PaymentType
{
    Cash,
    Credit,
    Debit,
    EletronicTransfer,
}