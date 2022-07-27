namespace Address_Book
{  /// <summary>
   /// UC1 : Ability to create Contact in Address Book
   /// </summary>
    public class Program
    {   
        //An Entrypoint of console App
        static void Main(string[] args)
        {
            int option;

            AddressBook addressBookObj = new AddressBook(); //Creating AddressBook Object

            Console.WriteLine("Welcome to Address Book Program"); //Welcome Message
            
            //Loop to continue adding contact until user wants to exit
            do
            {
                Console.WriteLine("\nEnter from the below options:");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                    addressBookObj.AddContact(); //Calling AddressBook AddContact method using AddressBook object
                else if(option != 2)
                    Console.WriteLine("Enter valid option");


            } while (option != 2); //continue till user wants to add contact
        }
    }
}