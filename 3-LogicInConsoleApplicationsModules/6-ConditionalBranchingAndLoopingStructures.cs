using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace csharpfoundations;

public class Animal
{
    public string Species { get; set;}
    public string ID { get; set; }
    public string Age { get; set; } 
    public string Nickname { get; set; }
    public string PhysicalDescription { get; set; }
    public string PersonalityDescription { get; set; }

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
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Nickname: {Nickname}");
        Console.WriteLine($"Physical Description: {PhysicalDescription}");
        Console.WriteLine($"Personality Description: {PersonalityDescription}");
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
            Console.WriteLine();
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine("1. List all of our current pet information");
            Console.WriteLine("2. Add a new animal friend to the animalList list");
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
                    Console.WriteLine("Below is a list of all our animals:");
                    Console.WriteLine("--------------------");
                    foreach (Animal animal in animalList)
                    {
                        animal.Print();
                        Console.WriteLine("--------------------");
                    }
                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();
                    break;

                case "2":
                    // Add a new pet
                    string newSpecies = ""; string newID = ""; string newAge = "";
                    string newNick = ""; string newPhys = ""; string newPers = "";

                    // Get species
                    do
                    {
                        Console.WriteLine("Please enter the new animal's species");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newSpecies = readResult.Trim().ToLower();
                            Console.WriteLine($"The new animal's species will be: {newSpecies}");
                            Console.WriteLine();
                        }
                    } while (newSpecies == "");

                    // Get ID
                    do
                    {
                        Console.WriteLine("Please enter the new animal's ID");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newID = readResult.Trim().ToLower();
                            foreach (Animal animal in animalList)
                            {
                                if (animal.ID == readResult.Trim().ToLower())
                                {
                                    newID = "";
                                }
                            }

                            if (newID != "")
                            {
                                Console.WriteLine($"The new animal's ID will be: {newID}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("ID must be unique");
                            }

                        }
                    } while (newID == "");

                    // Get age
                    do
                    {
                        Console.WriteLine("Please enter the new animal's age");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newAge = readResult.Trim().ToLower();
                            Console.WriteLine($"The new animal's age will be: {newAge}");
                            Console.WriteLine();
                        }
                    } while (newAge == "");

                    // Get nickname
                    do
                    {
                        Console.WriteLine("Please enter the new animal's nickname");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newNick = readResult.Trim().ToLower();
                            Console.WriteLine($"The new animal's nickname will be: {newNick}");
                            Console.WriteLine();
                        }
                    } while (newNick == "");

                    // Get physical description
                    do
                    {
                        Console.WriteLine("Please enter the new animal's physical description");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newPhys = readResult.Trim().ToLower();
                            Console.WriteLine($"The new animal's physical description will be: {newPhys}");
                            Console.WriteLine();
                        }
                    } while (newPhys == "");

                    // Get personality description
                    do
                    {
                        Console.WriteLine("Please enter the new animal's personality description");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newPers = readResult.Trim().ToLower();
                            Console.WriteLine($"The new animal's species will be {newPers}");
                            Console.WriteLine();
                        }
                    } while (newPers == "");

                    animalList.Add(new Animal(newSpecies, newID, newAge, newNick, newPhys, newPers));
                    Console.WriteLine("New animal has been created");
                    Console.WriteLine("Press enter to continue back to the main menu");
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
                    // TODO: Edit an animal's age
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "6":
                    // TODO: Edit an animal's personality description
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

                case "exit":
                    break;

                default:
                    Console.WriteLine($"Invalid command: {menuSelection}");
                    break;

            }
        } while (menuSelection != "exit");
    }
}