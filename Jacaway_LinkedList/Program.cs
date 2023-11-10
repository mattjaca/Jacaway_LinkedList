using System.Transactions;
// Matthew Jacaway
// IT 113
// Notes:
// Behaviors:
namespace Jacaway_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList name = new LinkedList();
            string choice;

            do
            {
                Console.WriteLine("Press 1 to add an item.");
                Console.WriteLine("Press 2 to remove an item.");
                Console.WriteLine("Press 3 to search for an item.");
                Console.WriteLine("Press 4 to print all names.");
                Console.WriteLine("Press 5 to Exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the name you'd like to add.");
                    choice = Console.ReadLine();
                    name.Add(choice);
                    Console.WriteLine("You added " + choice + " to the list!");
                }
                if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the name you want to remove.");
                    choice = Console.ReadLine();
                    bool found = name.Remove(choice);
                    if(found == true)
                    {
                        name.Remove(choice);
                        Console.WriteLine("You removed " + choice + ".");
                    }
                    else
                    {
                        Console.WriteLine("Couldn't find name.");
                    }
                }
                if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the name you're searching for.");
                    choice = Console.ReadLine();
                    Node found = name.Contains(choice);
                    if (found != null)
                    {
                        Console.WriteLine("Match found!!!");
                    }
                    else
                    {
                        Console.WriteLine("No match found.");
                    }
                }
                if (choice == "4")
                {
                    Console.Clear();
                    name.Print();
                }

            } while(choice != "5");
        }
    }
}