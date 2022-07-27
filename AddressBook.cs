using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddressBook
    {
        List<Contact> addressBook; //Declaring addressBook

        public AddressBook()
        {
            addressBook = new List<Contact>(); //Creating addressBook list to store contact of Contact Class type
        }

        //Method to add contact
        public void AddContact()
        {
            Contact contact = new Contact(); //Creating object of Contact Class to create a new contact
            this.addressBook.Add(contact); //Adding object to addressBook List
        }
    }
}

