using System;

class Program
{
    static void Main(string[] args)
    {
        
        // customer 1 | total = 34 + 35 (shipping)
        Address a1 = new Address("Narra St.","Rizal", "Tanay", "Philippines");
        Customer c1 = new Customer("Eunice Ann Dollete", a1);
        Product p1 = new Product(0001, "Apples", 10.50, 1);
        Product p2 = new Product(0002, "Mango", 11, 1);
        Product p3 = new Product(0003, "Kiwi", 12.50, 1);

        List<Product> products1 = new List<Product> {p1, p2, p3};
        Order order1 = new Order(c1, products1);

        Console.WriteLine($"Customer One: ");
        // Packing Label
        Console.WriteLine($"Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        
        // Shipping Label
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        // Total Price Order
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");

        Console.WriteLine();
        Console.WriteLine();


        // customer 2 | total = 25.50 + 5 (shipping)
        Address a2 = new Address("School St.", "Lake Shore", "IL", "USA");
        Customer c2 = new Customer("John Smith", a2);
        Product p4 = new Product(0004, "Durian", 5, 2);
        Product p5 = new Product(0005, "Grapes", 5.75, 2);
        Product p6 = new Product(0006, "Banana", 2, 2);

        List<Product> products2 = new List<Product> {p4, p5, p6};
        Order order2 = new Order(c2, products2);

        Console.WriteLine($"Customer Two: ");
        // Packing Label
        Console.WriteLine($"Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        
        // Shipping Label
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        // Total Price Order
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}