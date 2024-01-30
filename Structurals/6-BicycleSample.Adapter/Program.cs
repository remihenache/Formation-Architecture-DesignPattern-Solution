namespace BicycleSample.Adapter;

public class PaymentSystemAdapter : IOldPaymentSystem
{
    private readonly NewPaymentSystem newPaymentSystem;

    public PaymentSystemAdapter(NewPaymentSystem newPaymentSystem)
    {
        this.newPaymentSystem = newPaymentSystem;
    }

    public void ProcessPayment(string paymentDetails)
    {
        // map de payementdetails to new payment system details
        newPaymentSystem.ExecuteTransaction(paymentDetails);
        // map de la reponse du new payement system to old payment system response
    }
}

internal class Program
{
    private static void Main()
    {
        // Votre tâche est de créer un adaptateur qui permet au OrderManagementSystem
        // de fonctionner avec le NewPaymentSystem sans changer son code.
        // Utilisation de l'adaptateur pour permettre au système de gestion des commandes de fonctionner avec le nouveau système de paiement

        var orderSystem = new OrderManagementSystem(new PaymentSystemAdapter(new NewPaymentSystem()));
        orderSystem.ProcessOrder("Order1", "PaymentDetails1");
    }
}