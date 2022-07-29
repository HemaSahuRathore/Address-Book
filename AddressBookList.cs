using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddressBookList
    {
        public static int numOfBook = 0;

        public static List<AddressBook> listOfAddressBook = new List<AddressBook>();
        public static Dictionary<AddressBook, String> addressBookList = new Dictionary<AddressBook, String>();

        //Method to add Address Book
        public void AddAddressBook()
        {
            Console.Write("Please Enter the Address Book Name: ");
            String addressBookName = Console.ReadLine();
            listOfAddressBook.Add(new AddressBook());
            addressBookList.Add(listOfAddressBook[numOfBook], addressBookName);
            numOfBook++;
        }

        //Method to display Address Book List
        public void DisplayAddressBookList()
        {
            foreach (var addressbook in addressBookList)
            {
                Console.WriteLine(addressbook);
            }
        }

        //Method to select an Address Book
        public void SelectAddressBookToAddContact()
        {
            DisplayAddressBookList();
            Console.Write("Enter the Address Book Name to display: ");
            String addressBookName = Console.ReadLine();

            foreach (KeyValuePair<AddressBook, String> addressbook in addressBookList)
            {
                if (addressbook.Value == addressBookName)
                {
                    AddressBook addressBook = addressbook.Key;
                    addressBook.contactMenu();
                }
            }
        }
    }
}
