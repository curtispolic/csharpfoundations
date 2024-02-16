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

    public Animal()
    {
        Species = "";
        ID = "";
        Age = "";
        Nickname = "";
        PhysicalDescription = "";
        PersonalityDescription = "";
    }

    public void Print()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Species: {Species}");
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
        bool validSearch;
        Animal editAnimal = new();
        string[] searchTerms;
        List<Animal> animalList = new()
        {
            // Pre-seeded data
            new Animal("dog", "d1", "2", "lola",
            "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
            "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses."),
            new Animal("dog", "d2", "9", "loki",
            "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
            "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs."),
            new Animal("cat", "c3", "1", "puss",
            "small white female weighing about 8 pounds. litter box trained.",
            "friendly"),
            new Animal("cat", "c4", "?", "", "", "")
        };

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

            switch(menuSelection.ToLower())
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
                    string newSpecies = ""; string newAge = "";
                    string newNick = ""; string newPhys = ""; string newPers = "";

                    // Get species
                    do
                    {
                        Console.WriteLine("Please enter the new animal's species (dog or cat)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            if (readResult.ToLower() == "dog" || readResult.ToLower() == "cat")
                            {
                                newSpecies = readResult.ToLower();
                                Console.WriteLine($"The new animal's species will be: {newSpecies}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Species must be \"dog\" or \"cat\"");
                            }
                        }
                    } while (newSpecies == "");

                    // Generate ID
                    string newID = newSpecies.Substring(0,1) + (animalList.Count + 1).ToString();

                    bool validAge = false;
                    int newAgeNum;
                    // Get age
                    do
                    {
                        Console.WriteLine("Please enter the new animal's age, or \"?\" if unknown");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            if (readResult != "?")
                            {
                                validAge = int.TryParse(readResult, out newAgeNum);
                                if (validAge)
                                {
                                    newAge = newAgeNum.ToString();
                                    Console.WriteLine($"The new animal's age will be: {newAgeNum}");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid age");
                                }
                            }
                            else
                            {
                                validAge = true;
                                newAge = "?";
                                Console.WriteLine($"The new animal's age will be: {newAge}");
                                Console.WriteLine();
                            }
                        }
                    } while (!validAge);

                    // Get nickname
                    do
                    {
                        Console.WriteLine("Please enter the new animal's nickname");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            newNick = readResult.Trim().ToLower();
                            if (newNick == "")
                            {
                                newNick = "tbd";
                            }
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
                            if (newPhys == "")
                            {
                                newPhys = "tbd";
                            }
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
                            if (newPers == "")
                            {
                                newPers = "tbd";
                            }
                            Console.WriteLine($"The new animal's species will be: {newPers}");
                            Console.WriteLine();
                        }
                    } while (newPers == "");

                    animalList.Add(new Animal(newSpecies, newID, newAge, newNick, newPhys, newPers));
                    Console.WriteLine("New animal has been created");
                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();

                    break;

                case "3":
                    // Ensure ages and personality descriptions are complete
                    foreach (Animal animal in animalList)
                    {
                        bool correctAge = false;
                        bool correctPhys = false;

                        // Ensure the age is correct and if not, get a correct one
                        // The _ just discards the actual int
                        correctAge = int.TryParse(animal.Age, out _);
                        
                        while (!correctAge)
                        {
                            Console.WriteLine($"Please enter the age for Animal ID: {animal.ID}");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                if (readResult != "?")
                                {
                                    correctAge = int.TryParse(readResult, out _);
                                    if (correctAge)
                                    {
                                        animal.Age = readResult;
                                        Console.WriteLine($"Setting age to: {animal.Age}");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid age");
                                    }
                                }
                                else
                                {
                                    correctAge = true;
                                    animal.Age = "?";
                                    Console.WriteLine($"Setting age to: {animal.Age}");
                                    Console.WriteLine();
                                }
                            }
                        }

                        // Ensure physical description is correct and if not, get one
                        if (animal.PhysicalDescription != null)
                        {
                            if (animal.PhysicalDescription != "")
                            {
                                correctPhys = true;
                            }
                        }

                        while (!correctPhys)
                        {
                            Console.WriteLine($"Please enter the physical description for Animal ID: {animal.ID}");
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animal.PhysicalDescription = readResult.Trim().ToLower();
                                correctPhys = true;
                                Console.WriteLine($"Setting physical description to: {animal.PhysicalDescription}");
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("Age and physical description fields are complete for all of our friends");
                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();
                    break;

                case "4":
                    // Ensure nickname and personality fields are correct and complete
                    foreach (Animal animal in animalList)
                    {
                        bool correctNick = false;
                        bool correctPers = false;

                        // Ensure nickname is correct and if not, get one
                        if (animal.Nickname != null)
                        {
                            if (animal.Nickname != "")
                            {
                                correctNick = true;
                            }
                        }

                        while (!correctNick)
                        {
                            Console.WriteLine($"Please enter the nickname for Animal ID: {animal.ID}");
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animal.Nickname = readResult.Trim().ToLower();
                                correctNick = true;
                                Console.WriteLine($"Setting nickname to: {animal.Nickname}");
                                Console.WriteLine();
                            }
                        }

                        // Ensure personality description is correct and if not, get one
                        if (animal.PersonalityDescription != null)
                        {
                            if (animal.PersonalityDescription != "")
                            {
                                correctPers = true;
                            }
                        }

                        while (!correctPers)
                        {
                            Console.WriteLine($"Please enter the personality description for Animal ID: {animal.ID}");
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animal.PersonalityDescription = readResult.Trim().ToLower();
                                correctPers = true;
                                Console.WriteLine($"Setting personality description to: {animal.PersonalityDescription}");
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("Nickname and personality description fields are complete for all of our friends");
                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();
                    break;

                case "5":
                    // Edit an animal's age
                    validSearch = false;
                    // editAnimal must be a blank instance to allow use of a local variable later
                    do
                    {
                        Console.WriteLine("Please enter the ID of the animal whose name you wish to edit:");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            if (readResult.ToLower() == "exit") break;
                            foreach (Animal animal in animalList)
                            {
                                if (animal.ID == readResult.ToLower())
                                {
                                    validSearch = true;
                                    editAnimal = animal;
                                }
                            }
                        }
                    } while (!validSearch);

                    do
                    {
                        validAge = false;
                        Console.WriteLine($"Enter the new age for animal {editAnimal.ID}");
                        readResult = Console.ReadLine();
                        int temp;
                        if (int.TryParse(readResult, out temp))
                        {
                            editAnimal.Age = temp.ToString();
                            validAge = true;
                        }
                    } while (!validAge);

                    Console.WriteLine($"Animal {editAnimal.ID}'s age has been changed to {editAnimal.Age}");
                    
                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();
                    break;

                case "6":
                    // TODO: Edit an animal's personality description
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                    break;

                case "7":
                    // Display all cats with a selected characteristic
                    validSearch = false;

                    do
                    {
                        Console.WriteLine("Please enter the characteristic you desire in your cat:");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            validSearch = true;
                        }
                    } while (!validSearch);

                    List<Animal> searchReturn = new();

                    foreach (Animal animal in animalList)
                    {
                        if (animal.Species == "cat")
                        {
                            #pragma warning disable CS8604 // Possible null reference argument.
                            if (animal.PhysicalDescription.Contains(readResult) || animal.PersonalityDescription.Contains(readResult))
                            {
                                searchReturn.Add(animal);
                            }
                            #pragma warning restore CS8604 // Possible null reference argument.
                        }
                    }

                    if (searchReturn.Count == 0)
                    {
                        Console.WriteLine("We couldn't find any matches :(");
                    }
                    else
                    {
                        Console.WriteLine($"We found {searchReturn.Count} matches:");
                        Console.WriteLine();
                        foreach (Animal animal in searchReturn)
                        {
                            animal.Print();
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine("Press enter to continue back to the main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    // Display all dogs with selected characteristics
                    validSearch = false;

                    do
                    {
                        Console.WriteLine("Please enter the characteristics you desire in your dog (comma separated):");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            validSearch = true;
                        }
                    } while (!validSearch);


                    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    searchTerms = readResult.Split(',');
                    #pragma warning restore CS8602 // Dereference of a possibly null reference.

                    searchReturn = new();
                    foreach (Animal animal in animalList)
                    {
                        if (animal.Species == "dog")
                        {
                            bool matchesTerms = false;
                            foreach (string str in searchTerms)
                            {
                                if (animal.PhysicalDescription.Contains(str.Trim()) || animal.PersonalityDescription.Contains(str.Trim()))
                                {
                                    if (!searchReturn.Contains(animal))
                                        searchReturn.Add(animal);
                                    matchesTerms = true;
                                    Console.WriteLine($"Our dog {animal.Nickname} is a match for \"{str}\"");
                                }
                            }
                            if (matchesTerms)
                            {
                                Console.WriteLine();
                                animal.Print();
                                Console.WriteLine();
                            }
                        }
                    }

                    if (searchReturn.Count == 0)
                    {
                        Console.WriteLine("We couldn't find any matches :(");
                    }

                    Console.WriteLine("Press enter to continue back to the main menu");
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