using System;

class Program
{
    static void Main(string[] args)
    {
        // Orders list.
        List<Order> orders = new List<Order>();

        // Products 1.
        List<Product> products1 = new List<Product>();
        // Product 1-1.
        Product product1_1 = new Product("Hairbrush", "H-322", 9.98, 1);
        products1.Add(product1_1);
        // Product 1-2.
        Product product1_2 = new Product("SD Card", "SD-4509", 14.70, 3);
        products1.Add(product1_2);
        // Address 1.
        Address address1 = new Address("1st Street", "New York City", "New York", "USA");
        // Customer 1.
        Customer customer1 = new Customer("Chell", address1);
        // Order 1.
        Order order1 = new Order(products1, customer1);
        orders.Add(order1);

        // Products 2.
        List<Product> products2 = new List<Product>();
        // Product 2-1.
        Product product2_1 = new Product("Art Kit", "ART-56008", 36.99, 1);
        products2.Add(product2_1);
        // Product 2-2.
        Product product2_2 = new Product("Sketch Book", "SK-284377", 14.98, 3);
        products2.Add(product2_2);
        // Product 2-3.
        Product product2_3 = new Product("Headphones", "HP-4428", 19.99, 2);
        products2.Add(product2_3);
        // Address 2.
        Address address2 = new Address("2nd Street", "Montreal", "Quebec", "Canada");
        // Customer 2.
        Customer customer2 = new Customer("Steven", address2);
        // Order 2.
        Order order2 = new Order(products2, customer2);
        orders.Add(order2);

        foreach(Order order in orders)
        {
            // Get packing label.
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.DisplayPackingLabel());
            // Get shipping label.
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.DisplayShippingLabel());
            // Get total cost.
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost()}");

            // Blank line.
            Console.WriteLine();
        }
    }
}