using System;

namespace ECommerceSystem
{
    public class Discount
    {
        public double CalculateDiscount(double originalPrice, double discountPercentage)
        {
            double discountedPrice = originalPrice - (originalPrice * discountPercentage / 100);
            Console.WriteLine($"Original price: ${originalPrice}, Discounted price: ${discountedPrice}");
            return discountedPrice;
        }

        public void ApplyBulkDiscount(double totalAmount, int itemCount)
        {
            if (itemCount > 10)
            {
                double discount = totalAmount * 0.10;  // Feature in feature-discount branch
                Console.WriteLine($"Bulk discount applied: ${discount}");
            }
            else
            {
                Console.WriteLine("No bulk discount applied.");
            }
        }
    }
}
