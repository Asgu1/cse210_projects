using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create first order - USA customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "LAP001", 999.99, 1);
        Product product2 = new Product("Mouse", "MOU001", 25.50, 2);
        Product product3 = new Product("Keyboard", "KEY001", 75.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order - International customer
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Tablet", "TAB001", 299.99, 1);
        Product product5 = new Product("Case", "CAS001", 15.99, 3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display first order
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Display second order
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}