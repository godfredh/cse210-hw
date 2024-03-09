using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message to the user
        Console.WriteLine("Greetings! You've entered the Journal program.") ;

         // Instances of JournalEntry, PromptGenerator, and JournalData classes
        JournalEntry storeData = new JournalEntry();
        PromptGenerator prompting = new PromptGenerator();
        JournalData fileName1 = new JournalData();

        // Main loop for the journal program
        while (true)
        {
            // Menu options for the user
            Console.WriteLine("Please select one of these: ");
            Console.WriteLine($"1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What's up today? "); 

             // User choice input 
            int choice = int.Parse(Console.ReadLine());

            // User choices handling
            if (choice == 1)
            {
                // Check if additional information is needed
                if (storeData._count == 0)
                {
                    prompting.MoreInfo();
                }

                // Display prompts and collect user entries
                prompting.PromptsDisplay();
                storeData.SetEntry(prompting._sentence, prompting._prompt, prompting._title, 
                                prompting._author, prompting._goal);
                fileName1.AddEntry(storeData);
            }
            else if (choice == 2)
            {
                // Display all journal entries
                fileName1.EntryDisplay();
            }
            else if (choice == 3)
            {
                // Load entries from a file
                fileName1.LoadFile();
            }
            else if (choice == 4)
            {
                // Set goals and save entries to a file
                prompting.Goals();
                storeData.SetEntry(prompting._title,prompting._author, prompting._prompt, prompting._sentence, prompting._goal); //call twice to make sure that the goals are saved into the file
                fileName1.SaveFile();
            }
            else if (choice == 5)
            {
                // Quit the program
                Console.WriteLine("I can't wait to hear from you soon!!\n");
                break;
            }
            else
            {
                // Invalid choice message
                Console.WriteLine("Sorry, please select one of the numbers display in the menu \n");
            }
        }
    }
}