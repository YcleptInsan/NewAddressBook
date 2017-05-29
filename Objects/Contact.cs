using System.Collections.Generic;

namespace AddressBook
{
	public class Contact
	{
		private static List<Contact> _instances = new List<Contact> {};
		private string _name;
		private string _phoneNumber;
		private string _address;
    private int _id;

		public Contact (string contactName, string contactPhonenumber, string contactAddress)
		{
			_name = contactName;
			_phoneNumber = contactPhonenumber;
			_address = contactAddress;
			_instances.Add(this);
		 _id = _instances.Count;
		}
		public string GetName()
		{
			return _name;
		}
		public void SetName(string newName)
		{
		 	_name = newName;
		}
		public string GetPhoneNumber()
		{
			return _phoneNumber;
		}
		public void SetPhoneNumber(string newPhoneNumber)
		{
		 	_phoneNumber = newPhoneNumber;
		}
		public string GetAddress()
		{
			return _address;
		}
		public void SetAddress(string newAddress)
		{
		 	_address = newAddress;
		}
	}
}
