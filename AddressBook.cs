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
                Console.WriteLine("Contact {0}", i + 1);
                Console.WriteLine(addressBook[i]);
            }
        }

        public void contactMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\nEnter from the below options:");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Display Existing contact");
                Console.WriteLine("3. Edit Existing contact");
                Console.WriteLine("4. Delete Existing contact");
                Console.WriteLine("5. Add Multiple contact");
                Console.WriteLine("6. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                //Loop to continue until user wants to exit
                switch (option)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        DisplayContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        AddMultipleContact();
                        break;
                    case 6:
                        break;
                }

            } while (option != 6);

        }

        public override string ToString() //overriding ToString method of Object class to diplay the objects
        {
            return "No Of Contacts : " + addressBook.Count;
        }
    }
}
