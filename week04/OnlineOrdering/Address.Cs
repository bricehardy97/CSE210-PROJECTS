public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string _streetAddress, string _city, string _state, string _country)
    {
        this._streetAddress = _streetAddress;
        this._city = _city;
        this._state = _state;
        this._country = _country;
    }

    // In USA or not 
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Address
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}