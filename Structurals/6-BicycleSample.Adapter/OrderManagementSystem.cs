namespace BicycleSample.Adapter;

// Système de gestion des commandes existant
public class OrderManagementSystem
{
    private readonly IOldPaymentSystem paymentSystem;

    public OrderManagementSystem(IOldPaymentSystem paymentSystem)
    {
        this.paymentSystem = paymentSystem;
    }

    public void ProcessOrder(string orderDetails, string paymentDetails)
    {
        Console.WriteLine($"Order processed: {orderDetails}");
        paymentSystem.ProcessPayment(paymentDetails);
    }
}