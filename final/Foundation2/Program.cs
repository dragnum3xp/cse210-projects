using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Product1", "123", 10.5m, 2));
        products1.Add(new Product("Product2", "456", 20m, 1));

        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotal()}");

        Console.WriteLine();

        Address address2 = new Address("456 Oak St", "Othertown", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Product3", "789", 15m, 3));

        Order order2 = new Order(products2, customer2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotal()}");
    }   
}