using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("34 Canyon Court W", "Lethbridge", "AB", "Canada");
        Customer customer1 = new Customer("Jackson Woodlock", address1);

        Product product1a = new Product("Xbox Controller", "A113", 70, 1);
        Product product1b = new Product("Deck of Pokemon Cards", "MA4537", 7, 4);

        Order Order1 = new Order(customer1);
        Order1.AddProduct(product1a);
        Order1.AddProduct(product1b);

        Console.WriteLine("=== Order1 ===");
        Console.WriteLine(Order1.GetPackingLabel());
        Console.WriteLine(Order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${Order1.GetTotalCost()}");
        Console.WriteLine();
        

        Address address2 = new Address("456", "Austin", "TX", "USA");
        Customer customer2 = new Customer("Tanner Paxton", address2);

        Product product2a = new Product("SkateBoard", "GX6754", 45, 1);
        Product product2b = new Product("5Gum Pack of 12", "TR8971", 2, 10);

        Order Order2 = new Order(customer2);
        Order2.AddProduct(product2a);
        Order2.AddProduct(product2b);

        Console.WriteLine("=== Order2 ===");
        Console.WriteLine(Order2.GetPackingLabel());
        Console.WriteLine(Order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${Order2.GetTotalCost()}");
        Console.WriteLine();
    }
}