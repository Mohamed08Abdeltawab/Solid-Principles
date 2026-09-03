
namespace PaymentService
{
    public class PaymentService
    {
        private IPaymentService _paymentService;
        public PaymentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentService.ProcessPayment(amount);
        }
    }

    public interface IPaymentService
    {
        public void ProcessPayment(decimal amount);
    }

    public class PayPal : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through PayPal.");
        }
    }
    public class CreditCard : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Credit Card.");
        }
    }
    public class BankTransfer : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Bank Transfer.");
        }
    }
    public class Bitcoin : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Bitcoin.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentService ps = new PaymentService(new PayPal());
            ps.ProcessPayment(100.00m);

            ps = new PaymentService(new CreditCard());
            ps.ProcessPayment(200.00m);

            ps = new PaymentService(new BankTransfer());
            ps.ProcessPayment(300.00m);

            ps = new PaymentService(new Bitcoin());
            ps.ProcessPayment(400.00m);
        }
    }
}