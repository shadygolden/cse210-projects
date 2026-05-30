using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Doe",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P100",
            850.00,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P200",
            25.00,
            2
        );

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);

        Order order1 = new Order(customer1, products1);

        // Second Order
        Address address2 = new Address(
            "45 King Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer(
            "Alice Brown",
            address2
        );

        Product product3 = new Product(
            "Keyboard",
            "P300",
            45.00,
            1
        );

        Product product4 = new Product(
            "Monitor",
            "P400",
            220.00,
            2
        );

        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);

        Order order2 = new Order(customer2, products2);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("---------------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("---------------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}