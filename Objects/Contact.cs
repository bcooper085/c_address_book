using System.Collections.Generic;

namespace Contact.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;

    public Contact (string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public string GetAddress()
    {
      return _address;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
  }
}
