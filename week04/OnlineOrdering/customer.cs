using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public string GetName()
    {
        return _customerName;
    }

}