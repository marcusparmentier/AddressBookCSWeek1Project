using System.Collections.Generic;
// using System;

namespace AddressBookCS.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};

    //Constructor
    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}

// _name, _phoneNumber, _address


// public void SetName(string newName)
// {
//   _name = newName;
// }
// public void SetPhoneNumber(string newPhoneNumber)
// {
//   _phoneNumber = newPhoneNumber;
// }
// public void SetAddress(string newAddress)
// {
//   _address = newAddress;
// }
