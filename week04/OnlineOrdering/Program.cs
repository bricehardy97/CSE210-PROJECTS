class Program
{
    static void Main(string[] args)
    {
        // 
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Smartphone", 102, 499.99m, 2);

        // Creating customer addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Rd", "Vancouver", "BC", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating orders
        List<Product> productsForOrder1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productsForOrder1, customer1);

        List<Product> productsForOrder2 = new List<Product> { product2 };
        Order order2 = new Order(productsForOrder2, customer2);

        // Displaying Order 1 details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        // Displaying Order 2 details
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}