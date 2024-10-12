using System;

namespace ECommerceSystem
{
    public class Checkout
    {
        public void ProcessCheckout(double totalAmount)
        {
            Console.WriteLine($"Processing checkout for ${totalAmount}");
        }

        public void ApplyTax(double taxAmount)
        {
            Console.WriteLine($"Applied tax: ${taxAmount}");  // Feature in feature-checkout branch
        }

        public void ConfirmOrder()
        {
            Console.WriteLine("Order confirmed.");
        }
    }
}
