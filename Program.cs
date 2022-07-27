namespace Address_Book
{  /// <summary>
   /// UC3 : Ability to edit existing contact person using their name
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
                Console.WriteLine("2. Display Existing contact");
                Console.WriteLine("3. Edit Existing contact");
                Console.WriteLine("4. Delete Existing contact");
                Console.WriteLine("5. Exit");
                option = Convert.ToInt32(Console.ReadLine());

                //Loop to continue until user wants to exit
                switch (option)
                {
                    case 1:
                        addressBookObj.AddContact();
                        break;
                    case 2:
                        addressBookObj.DisplayContact();
                        break;
                    case 3:
                        addressBookObj.EditContact();
                        break;
                    case 4:
                        addressBookObj.DeleteContact();
                        break;
                    case 5:
                        break;

                 } 

            } while (option != 5); //continue till user wants to add contact
        }
    }
}