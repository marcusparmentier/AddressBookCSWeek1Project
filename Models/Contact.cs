using System.Collections.Generic;


namespace AddressBookCS.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    //Constructor
    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
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
    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
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
