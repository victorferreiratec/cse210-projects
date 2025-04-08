public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;


    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }
    // "C270 HD WEBCAM", 0772, 194.59, 55
    public double CalcProductPrice()
    {
        double totalCostOfProduct = _price * _quantity;
        return totalCostOfProduct;
    }

    public string GetNameAndID()
    {
        return $"{_name}: {_productID}";
    }

}