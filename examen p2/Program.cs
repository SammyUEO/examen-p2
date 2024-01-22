using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numele clientului: ");
        string customerName = Console.ReadLine();

        Console.Write("Introduceti data comenzii (MM/DD/YYYY): ");
        DateTime orderDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Introduceti valoarea totala a comenzii: ");
        decimal orderTotal = decimal.Parse(Console.ReadLine());

        Order order = new Order(customerName, orderDate, orderTotal);

        Console.Write("Alegeți metoda de plată (Card/PayPal/CryptoWallet): ");
        string paymentMethod = Console.ReadLine();

        PaymentSystem paymentSystem;

        switch (paymentMethod.ToLower())
        {
            case "card":
                paymentSystem = new CardPayment();
                break;

            case "paypal":
                paymentSystem = new PayPalPayment();
                break;

            case "cryptowallet":
                paymentSystem = new CryptoWalletPayment();
                break;

            default:
                Console.WriteLine("Metoda de plata invalida.");
                return;
        }

        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.FulfillOrder(order, paymentSystem);
    }
}
