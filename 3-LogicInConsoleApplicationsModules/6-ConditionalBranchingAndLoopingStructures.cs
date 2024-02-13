using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace csharpfoundations;

public class Animal
{
    private string Species { get; set;}
    private string ID { get; set; }
    private string Age { get; set; } 
    private string Nickname { get; set; }
    private string PhysicalDescription { get; set; }
    private string PersonalityDescription { get; set; }

    public Animal(string newSpecies, string newID, string newAge, string newNick, string newPhys, string newPers)
    {
        Species = newSpecies;
        ID = newID;
        Age = newAge;
        Nickname = newNick;
        PhysicalDescription = newPhys;
        PersonalityDescription = newPers;
    }

    public void Print()
    {
        return;
    }
}

public class ConditionalBranchingAndLoopingStructures
{
    public static void Run()
    {
        string menuSelection = "";
        string? readResult;
        List<Animal> animalList = new();

        // Menu
        do
        {
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine("1. List all of our current pet information");
            Console.WriteLine("2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine("5. Edit an animal's age");
            Console.WriteLine("6. Edit an animal's personality description");
            Console.WriteLine("7. Display all cats with a specified characteristic");
            Console.WriteLine("8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();

            if (readResult != null)
            {
                menuSelection = readResult;
            }
            else
            {
                continue;
            }

            switch(menuSelection)
            {
                case "1":
                    // List all current pets
                    foreach (Animal animal in animalList)
                    {
                        animal.Print();
                    }
                    Console.ReadLine();
                    break;

                case "2":
                    // Add a new pet
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "5":
                    // Edit an animal's age
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "6":
                    // Edit an animal's personality description
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "8":
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine($"Invalid command: {menuSelection}");
                    break;

            }
        } while (menuSelection != "exit");
    }
}