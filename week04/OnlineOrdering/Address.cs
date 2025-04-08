public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress,string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        //if not in the USA return false
        return false;
    }

    public string DisplayAddress()
    {
        string address = $"{_streetAddress}, {_city}, {_stateProvince}\n{_country}";
        return address;
    }
}