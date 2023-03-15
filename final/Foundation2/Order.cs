public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double shippingCost;
        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        double productCost = 0;
        foreach (Product product in _products)
        {
            productCost += product.CalculateProductPrice();
        }

        return shippingCost + productCost;
    }
    public string DisplayPackingLabel()
    {
        string text = "";
        foreach (Product product in _products)
        {
            text += $"\t{product.GetName()} {product.GetId()}\n";
        }
        // Remove last newline from text.
        text = text.ToString().TrimEnd('\r', '\n');
        return text;
    }
    public string DisplayShippingLabel()
    {   
        string text = "";
        text += $"\t{_customer.GetName()}\n";
        text += $"{_customer.GetAddress().GetAddressString()}";
        return text;
    }
}