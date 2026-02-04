using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateorprovince;
    private string _country;

    public Address(string street, string city, string stateorprovince, string country)
    {
        _street = street;
        _city = city;
        _stateorprovince = stateorprovince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateorprovince}|n{_country}";
    }

    public string Street => _street;
    public string City => _city;
    public string StateorProvince => _stateorprovince;
    public string Country => _country;
}