namespace csharpfoundations;

public class MethodsWithParameters
{
    public static void Run()
    {
        void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
        {
            int diff = 0;
            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            } 
            else 
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            }

            for (int i = 0; i < times.Length; i++) 
            {
                int newTime = ((times[i] + diff)) % 2400;
                Console.WriteLine($"{times[i]} -> {newTime}");
            }
        }

        void DisplayStudents(string[] students) 
        {
            foreach (string student in students) 
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine();
        }

        // Pretty sure this is bad practice, probably should be defined inside the methods
        double pi = 3.14159;

        void PrintCircleArea(int radius)
        {
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        void PrintCircleCircumference(int radius)
        {
            double circumference = 2 * pi * radius;
            Console.WriteLine($"Circumference = {circumference}");
        }

        void PrintCircleInfo(int radius) 
        {
            Console.WriteLine($"Circle with radius {radius}");
            PrintCircleArea(radius);
            PrintCircleCircumference(radius);
        }

        void Multiply(int a, int b, int c) 
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }

        void PrintArray(int[] array) 
        {
            foreach (int a in array) 
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        void Clear(int[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = 0;
            }
        }

        void SetHealth(string status, bool isHealthy) 
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }

        // God these global variables bug me
        string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
        string[] rsvps = new string[10];
        int count = 0;

        // Example of optional parameters by setting a default value
        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            if (inviteOnly)
            {
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name)) {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }

        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }

        // Challenge method
        string CreateEmail(string firstName, string lastName, string domain)
        {
            string email = "";
            email += firstName.Substring(0, 2);
            email += lastName;
            email += "@";
            email += domain;
            return email.ToLower();
        }

        int[] schedule = {800, 1200, 1600, 2000};

        // Wow my methods takes parameters
        DisplayAdjustedTimes(schedule, 6, -6);
        Console.WriteLine();

        string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

        // Yes this is pretty obvious but I suppose
        DisplayStudents(students);
        DisplayStudents(new string[] {"Robert","Vanya"});
        Console.WriteLine();

        PrintCircleInfo(12);
        PrintCircleInfo(24);
        Console.WriteLine();

        // This is where they reach you shouldn't modify parameters passed in if they're value types
        // Only reference types

        // Passing a value
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");
        Console.WriteLine();

        // Passing a reference
        int[] array = {1, 2, 3, 4, 5};

        PrintArray(array);
        Clear(array);
        PrintArray(array);
        Console.WriteLine();

        // Trying to modify something immutable
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(status, false);
        Console.WriteLine($"End: {status}");
        Console.WriteLine();

        // All the RSVP calls and examples
        RSVP("Rebecca");
        RSVP("Nadia", 2, "Nuts");
        RSVP(name: "Linh", partySize: 2, inviteOnly: false);
        RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
        RSVP("Noor", 4, inviteOnly: false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();
        Console.WriteLine();

        // Challenge is to use the below arrays to produce email adresses
        string[,] corporate = 
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external = 
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";
        string internalDomain = "contoso.com";

        for (int i = 0; i < corporate.GetLength(0); i++) 
        {
            Console.WriteLine(CreateEmail(corporate[i,0], corporate[i,1], internalDomain));
        }

        for (int i = 0; i < external.GetLength(0); i++) 
        {
            Console.WriteLine(CreateEmail(external[i,0], external[i,1], externalDomain));
        }

    }
}