using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class PaymentSystem
{
    public abstract void ProcessPayment(decimal amount);
}
public class CardPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata online cu cardul este de {amount} RON.");
    }
}

public class PayPalPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata prin PayPal este de {amount} RON.");
    }
}

public class CryptoWalletPayment : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata folosind wallet crypto estea de {amount} RON.");
    }
}

