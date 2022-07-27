namespace Address_Book
{  /// <summary>
   /// UC1 : Ability to create Contact in Address Book
   /// </summary>
    public class Program
    {   
        //An Entrypoint of console App
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program"); //Welcome Message
            Console.ReadLine();

            Contact contact = new Contact(); //creating contact for Address Book
        }
    }
}