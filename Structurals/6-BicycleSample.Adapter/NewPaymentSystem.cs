namespace BicycleSample.Adapter;

public class NewPaymentSystem
{
    public void ExecuteTransaction(string paymentInfo)
    {
        Console.WriteLine($"Processing transaction with: {paymentInfo}");
    }
}