public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        return false;
    }

    public string GetNameAndAddress()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }
}