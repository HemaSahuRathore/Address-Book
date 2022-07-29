namespace Address_Book
{  /// <summary>
   /// UC6 : Ability to add Multiple Address Book
   /// </summary>
    public class Program
    {
        //An Entrypoint of console App
        static void Main(string[] args)
        {
            int option;

            AddressBookList addressBookListObj = new AddressBookList();


            Console.WriteLine("Welcome to Address Book Program"); //Welcome Message

            //Loop to continue adding contact until user wants to exit
            do
            {
                Console.WriteLine("\nEnter from the below options:");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Display Existing Address Book");
                Console.WriteLine("3. Add Contact to Address Book");
                Console.WriteLine("4. Exit");
                ;
                option = Convert.ToInt32(Console.ReadLine());

                //Loop to continue until user wants to exit
                switch (option)
                {
                    case 1:
                        addressBookListObj.AddAddressBook();
                        break;
                    case 2:
                        addressBookListObj.DisplayAddressBookList();
                        break;
                    case 3:
                        addressBookListObj.SelectAddressBookToAddContact();
                        break;
                    case 4:
                        break;
                }

            } while (option != 8); //continue till user wants to add contact
        }
    }
}