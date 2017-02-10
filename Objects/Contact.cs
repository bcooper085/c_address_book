using System.Collections.Generic;

namespace Contact.Objects
{
  public class Contact
  {
    private static List<Contact> _ instances = new List<Contact> {};
    private string _name;
    private string _phone;
    private int _id;
    private List<Contact> _contact;

    public Contact(string contactName)
    {
      _name = contactName;
      _phone = contactPhone
      _instances.Add(this);
      _id = _instances.Count;
      _contact = new List<Contact> {};
    }

    public string GetName()
    {
      return _name;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public int GetId()
    {
      return _id;
    }

    public List<Address> GetAddress()
    {
      return _contact;
    }

    public void AddAddress(Address newAddress)
    {
      _address.Add(newAddress);
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void Clear()
    {
      instances.Clear();
    }
  }
}
