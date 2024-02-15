class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotal()
    {
        decimal totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.CalculateTotal();
        }

        if (_customer.IsInUSA())
        {
            totalCost +=5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += address.GetFullAddress();
        return shippingLabel;
    }
}