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

        //Method to contact Multiple Contact
        public void AddMultipleContact()
        {
            Console.Write("\nPlease enter total number of contact you want to add : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Contact contact = new Contact();
                this.addressBook.Add(contact);
            }

        }

        //Method to edit contact based on name
        public void EditContact()
        {
            int contactFound = 0;

            if (addressBook.Count == 0) //if no contact found(empty list/Address Book)
                Console.WriteLine("No Contact Added!!!");
            else
            {
                Console.Write("Enter the Contact First Name : ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter the Contact Last Name : ");
                string newLastName = Console.ReadLine();

                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].firstName == newFirstName && addressBook[i].lastName == newLastName)
                    {
                        Console.WriteLine("Please input the new values for contact");
                        Contact contact = new Contact();
                        addressBook[i] = contact;
                        contactFound = 1;
                    }
                }
                if (contactFound == 0)
                    Console.WriteLine("Contact Information you entered not found. Please check added contacts and then try again!!!!");
            }
        }

        //method to delete contact based on name
        public void DeleteContact()
        {
            int foundContact = 0; //flag to check if contact found

            if (addressBook.Count == 0)  //if no contact found(empty list-Address Book)
                Console.WriteLine("No Contact Added!!!!!! Address Book is Empty.");
            else
            {
                Console.Write("Enter the Contact First Name : ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter the Contact First Name : ");
                string newLastName = Console.ReadLine();

                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].firstName == newFirstName && addressBook[i].lastName == newLastName)
                    {
                        Console.WriteLine("Deleting: " + addressBook[i].firstName + " " + addressBook[i].lastName + " Contact details...");
                        addressBook.Remove(addressBook[i]);
                        foundContact = 1; //changing flag value as contact found and deleted
                    }

                }
                if (foundContact == 0) //contact not found
                    Console.WriteLine("Contact Information you entered not found. Please check added contacts and then try again!!!!");
            }

        }

        //Method to display existing contact
        public void DisplayContact()
        {
            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("Contact {0}", i+1);
                Console.WriteLine(addressBook[i]);
            }
        }


    }
}

