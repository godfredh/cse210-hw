// I added a code that allows users to enter their name and the program refer to users by calling their names.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name\n> "); // Prompting user to input their name
        string userName = Console.ReadLine(); // Reading user's input
        Activity A1 = new Activity();
        int _nBreathing = 0;
        int _nReflecting = 0;
        int _nListing = 0;
        int choice = 0;

        // Main program loop
        while (choice != 4) // Loop until the user chooses to quit
        {
            Console.Clear(); // Clearing the console screen
            // Displaying welcome message with user's name
            Console.WriteLine($"Welcome,{userName}! Step into a space where self-reflection and positivity thrive. Here, we celebrate your journey of growth and resilience. Embrace the warmth of introspection as you uncover the treasures of your life, one moment at a time. Together, let's embark on a voyage of gratitude and self-discovery. Welcome to our community, where every step forward is met with encouragement and support. Dive in, and let the journey begin!");
            Console.WriteLine("Menu: \n  1. Breathing Activity \n  2. Reflecting Activity \n  3. Listing Activity \n 4.Quit");
            Console.Write("Choose an activity from the menu\n>: ");
            choice = int.Parse(Console.ReadLine()); // Reading user's choice

            string description = "";
            string option = "";

            // Switch statement to handle user's choice
            switch (choice)
            {
                case 1:
                    option = "Breathing Activity";
                    description = "This exercise is designed to promote relaxation by guiding you through slow, deliberate breathing. Empty your mind and concentrate on your breath.";
                    Console.WriteLine();
                    Breathing b1 = new Breathing(option, description);
                    b1.GetIntroPrompt();
                    b1.InAndOut();
                    b1.GetClosingMessage();
                    _nBreathing += 1;
                    break;

                case 2:
                    option = "Reflecting Activity";
                    description = "This activity encourages you to reflect on moments in your life where you've demonstrated strength and resilience. By doing so, you'll gain insight into your personal power and discover how you can apply it to various aspects of your life.";
                    Console.WriteLine();
                    Reflection r1 = new Reflection(option, description);
                    r1.GetIntroPrompt(); 
                    r1.GetPrompt();
                    r1.GetQuestion();
                    r1.GetClosingMessage();

                    _nReflecting += 1;
                    break;

                case 3:
                    option = "Listing Activity";
                    description = "This exercise will prompt you to contemplate the positive aspects of your life by encouraging you to list as many things as possible within specific areas.";
                    Console.WriteLine();
                    Listing l1 = new Listing(option, description);
                    l1.GetIntroPrompt();
                    l1.GetQuestion();
                    l1.GetClosingMessage();
                    _nListing +=1;
                    break;
                
                case 4:
                    Console.WriteLine("Thank you for using our program! Goodbye, and have a wonderful day!"); // Farewell message
                    break;
                default:
                    break;
            }
        }
        A1.History(_nBreathing, _nReflecting, _nListing); // Generating history report

    }
}