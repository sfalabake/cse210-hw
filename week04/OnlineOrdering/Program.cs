using System;

class Program
{
    static void Main()
    {
        // ----- Order 1 (USA) -----
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "TX",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A100", 3.50, 4));
        order1.AddProduct(new Product("Pen", "B200", 1.25, 6));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine("----------------------------------");

        // ----- Order 2 (International) -----
        Address address2 = new Address(
            "45 Kings Road",
            "London",
            "Greater London",
            "UK"
        );

        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "C300", 45.00, 1));
        order2.AddProduct(new Product("Water Bottle", "D400", 12.00, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
