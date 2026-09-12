using System;

public interface IPayWithCreditCard
{
    public void PayWithCreditCard();
}

public interface IPayWithPayPal
{
    public void PayWithPayPal();
}

public interface IPayWithBitcoin
{
    public void PayWithBitcoin();
}

public class CreditCardPayment : IPayWithCreditCard
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }

}

public class PayPalPayment : IPayWithPayPal
{

    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }
}

public class BitcoinPayment : IPayWithBitcoin
{

    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment with Bitcoin.");
    }
}

public class Payment : IPayWithCreditCard, IPayWithPayPal, IPayWithBitcoin
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }

    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal.");
    }

    public void PayWithBitcoin()
    {
        Console.WriteLine("Payment with Bitcoin.");
    }
}


public class Program
{
    public static void Main()
    {
        IPayWithCreditCard creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
        // creditCardPayment.PayWithPayPal();
        // creditCardPayment.PayWithBitcoin ();

        IPayWithPayPal payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();
        // payPalPayment.PayWithBitcoin();

        IPayWithBitcoin bitcoinPayment = new BitcoinPayment();
        bitcoinPayment.PayWithBitcoin();

        Payment payment = new Payment();
        payment.PayWithCreditCard();

        Console.ReadKey();

    }
}
