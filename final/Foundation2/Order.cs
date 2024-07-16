using System;
using System.Text;

// string builder : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
class Order
{
    //private int _orderId;
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        //_orderId = orderId;
        _products = products;
        _customer = customer;

    }

    public double TotalCost()
    {
        double totalCost = 0;


        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }

        // if customer living in US - true = 5 false = 35
        totalCost += _customer.LivingInUSA() ? 5 : 35;

        return totalCost;
    }

    public string PackingLabel()
    {
        var labels = new StringBuilder();

        foreach (var product in _products)
        {
            labels.AppendLine($"Product Id: {product.GetProductId()} - Product Name: {product.GetProductName()}");
        }

        return labels.ToString();
    }

    public string ShippingLabel()
    {
        var labels = new StringBuilder();

        // customer details
        labels.AppendLine(_customer.GetCustomerName());

        // customer address
        labels.AppendLine(_customer.GetCustomerAddress());

        return labels.ToString();

    }

}