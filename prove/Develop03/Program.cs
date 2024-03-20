// I ADDED A CODE THAT WILL HANDLE ERRORS IN SITUATIONS A USER 
// A USER ENETERS AN ALPHABET INSTEAD OF A POSITIVE INTEGER


using System;
// Required for the List<T> collection and the Console and Random classes.


class Program
{
    static void Main(string[] args)
    {
        // Initialize an empty list of strings to hold scripture references.
        List<string> referenceList = new List<string>{};

        // Initialize scripture verses as string variables.
        string verse1 = "I have told you these things, so that in me you may have peace. In this world you will have trouble. But take heart! I have overcome the world.";
        string verse2 = "The LORD is my strength and my shield; my heart trusts in him, and he helps me. My heart leaps for joy, and with my song I praise him.";

        Reference reference; // Declare a variable to hold the scripture reference object.

        // Create scripture reference objects with book name, chapter, and verse(s).
        Reference r1 = new Reference("John", 16, 33);
        Reference r2 = new Reference("Psalms", 28, 7);

         // Add the formatted references to the reference list.
        referenceList.Add(r1.GetReference());
        referenceList.Add(r2.GetReference());
        string verse = ""; // Variable to hold the chosen scripture verse.

        // Instantiate a Random object for generating random numbers.
        Random random  = new Random();
        // Generate a random index based on the count of the reference list.
        int Ref = random.Next(referenceList.Count());

        // Select the verse and reference based on the random index.
        if (Ref == 0)
        {
            reference = r1;
            verse = verse1;
        }
        else
        {
            reference = r2;
            verse = verse2;
        }

        // Clear the console window for clean output.
        Console.Clear(); 

        string play = ""; // Variable to control the game loop based on user input.
        // Create a Scripture object with the selected verse and reference.
        Scripture s1 = new Scripture(verse, reference);
        s1.Display(); // Display the scripture and reference.
        Console.Write("Please enter a positive number to show the number of words you want to hide :\n > "); 
        // Read the user input for the number of words to hide in the verse.
        int numToHide;
        while (!int.TryParse(Console.ReadLine(), out numToHide) || numToHide <= 0) // Error handling for numeric input.
{
        Console.WriteLine("Error: Please enter a valid positive number.");
        Console.Write("How many number do you want to hide at a time:\n > "); 
}
        // Game loop: continues until the user types "quit".
        while (play != "quit")
        {
            Console.WriteLine("\"Please press \"Enter\" to continue and type \"Quit\" to continue.\"");
            play = Console.ReadLine(); // Ensuring the input is case-insensitive.
            s1.HideAndShow(numToHide); // Hide the specified number of words in the verse.
            s1.Display(); // Display the updated verse.
        }
    }
}