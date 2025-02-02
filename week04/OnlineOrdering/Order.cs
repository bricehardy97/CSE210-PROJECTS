public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> _products, Customer _customer)
    {
        this._products = _products;
        this._customer = _customer;
    }

    public decimal GetTotalPrice()
    {
        decimal totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        decimal shippingCost = _customer._IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

   
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})";
        }
        return packingLabel;
    }

   
    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()}{_customer.GetAddress().GetFullAddress()}";
    }
}