class Product
{
    private int _productID;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public int GetID()
    {
        return _productID;
    }

    public string GetName()
    {
        return _name;
    }
}