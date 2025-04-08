public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {

        _products = products;
        _customer = customer;
    }



    public double CalcTotalPrice()
    {
        double productsPrice = 0;

        // Calculate total price of each products
        foreach (Product product in _products)
        {
            productsPrice += product.CalcProductPrice();
        }
        // Add shipping based on customer location
        double shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return productsPrice + shippingCost;
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetNameAndID());
        }

    }
    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetNameAndAddress());
    }
}