using System;

class Product
{
    private int _productId;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double totalCost = _price * _quantity;

        return totalCost;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }
}