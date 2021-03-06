using System;
using System.Collections.Generic;

namespace Contact_Book.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private string _phone;
    private int _id;
    private List<Address> _address;

    public Contact(string contactName, string contactPhone)
    {
      _name = contactName;
      _phone = contactPhone;
      _instances.Add(this);
      _id = _instances.Count;
      _address = new List<Address> {};
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
      return _address;
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
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static List<int> selectedContact(string name)
    {
      List<int> display = new List<int> {};
      foreach (Contact person in _instances)
      {
        if (person.GetName().Contains(name))
        {
          display.Add(person.GetId());
        }
      }
      return display;
    }
  }
}
