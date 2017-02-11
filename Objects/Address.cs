using System;
using System.Collections.Generic;

namespace Contact_Book.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _zip;
    private string _state;

    public Address (string street, string city, string zip, string state)
    {
      _street = street;
      _city = city;
      _zip = zip;
      _state = state;
    }

    public string GetStreet()
    {
      return _street;
    }
    public string GetCity()
    {
      return _city;
    }
    public string GetZip()
    {
      return _zip;
    }
    public string GetState()
    {
      return _state;
    }

    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public void SetZip(string newZip)
    {
      _zip = newZip;
    }

    public void SetState(string newState)
    {
      _state = newState;
    }
  }
}
