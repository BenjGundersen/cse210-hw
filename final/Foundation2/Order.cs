class Order
{
    List<Product> _products = new List<Product>();
    
    public void AddItem(Product product)
    {
        _products.Add(product);
    }
    public double SubTotal()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += (product.GetTotalPrice());
        }
        return subtotal;
    }
    public double ShippingCost(Address address)
    {
        double shipping = 0;
        if (address.GetCountry() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }

    public double TotalCost(Address address)
    {
        double subtotal = SubTotal();
        double shippingCost = ShippingCost(address);
        return subtotal + shippingCost;
    }

    public void PrintAllCosts(Address address)
    {
        Console.WriteLine($"Subtotal: {Math.Round(SubTotal(), 2)}");
        Console.WriteLine($"Shipping cost: {Math.Round(ShippingCost(address), 2)}");
        Console.WriteLine($"Total: {Math.Round(TotalCost(address), 2)}");
    }

    public void PrintPackingLabel() 
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetID()}, {product.GetName()}");
        }
    }

    public void PrintShippingLabel(Address address, Customer customer)
    {
        Console.WriteLine(address.DisplayAddress(customer));
    }

}