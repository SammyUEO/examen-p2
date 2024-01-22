using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderProcessor
{
    public void FulfillOrder(Order order, PaymentSystem paymentSystem)
    {
        Console.WriteLine($"Comanda pentru {order.Customer} in data de {order.Date.ToShortDateString()} cu totalul de {order.Total} RON.");

        
        paymentSystem.ProcessPayment(order.Total);
    }
}

