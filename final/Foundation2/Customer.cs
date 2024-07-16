using System;

class Customer
{
    protected string _name;
    protected Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivingInUSA()
    {
        if (_address.InUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.CompleteAddress();
    }




}