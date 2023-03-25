using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("car", 469, 20000, 2);
        Product product2 = new Product("water bottle", 11, 34.99, 10);
        Product product3 = new Product("bike", 50, 150, 3);

        Order order1 = new Order();
        Order order2 = new Order();
        Address address1 = new Address("291 W 7th N", "Rexburg", "ID", "USA");
        Address address2 = new Address("Gimleveien 5", "Kristiansand", "Agder", "Norway");
        Customer customer1 = new Customer("John Cena", address1);
        Customer customer2 = new Customer("Ben Gundersen", address2);

        order1.AddItem(product1);
        order1.AddItem(product3);
        order2.AddItem(product2);
        order2.AddItem(product3);

        order1.PrintAllCosts(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, customer1);
        Console.WriteLine();
        order2.PrintAllCosts(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, customer2);
    }
}