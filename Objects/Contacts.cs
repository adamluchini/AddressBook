using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
      private static List<Contact> _instances = new List<Contact> {};
      private int _id;
      private string _firstName;
      private string _lastName;
      private string _address;
      private string _phoneNumber;

    public Contact(string firstName, string lastName, string address, string phoneNumber)
    {
      _firstName = firstName;
      _lastName = lastName;
      _address = address;
      _phoneNumber = phoneNumber;
      _instances.Add(this);
    }


    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }

    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAllContacts()
    {
      return _instances;
    }

    public static Contact Find(int searchID)
    {
      return _instances[searchID-1];
    }

    public static void DeleteAll()
    {
      _instances.Clear();
    }

  }
}
