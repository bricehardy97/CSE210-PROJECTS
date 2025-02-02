public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string _name, Address _address)
    {
        this._name = _name;
        this._address = _address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // In USA or not
    public bool _IsInUSA()
    {
        return _address.IsInUSA();
    }
}