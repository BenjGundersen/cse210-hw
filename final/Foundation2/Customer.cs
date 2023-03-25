class Customer
{
    private string _customerName;

    public Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerAddress = customerAddress;
        _customerName = customerName;
    }
    public string GetName()
    {
        return _customerName;
    }
}