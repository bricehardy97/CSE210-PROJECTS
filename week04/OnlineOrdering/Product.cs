public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string _name, int _productId, decimal _price, int _quantity)
    {
        this._name = _name;
        this._productId = _productId;
        this._price = _price;
        this._quantity = _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Total Cost 
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}