using System;
using System.Collections.Generic;

namespace ECommerceSystem
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"Added item to inventory: {item}");
        }

        public void RemoveItem(string item)
        {
            items.Remove(item);
            Console.WriteLine($"Removed item from inventory: {item}");  // Feature in feature-inventory branch
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
