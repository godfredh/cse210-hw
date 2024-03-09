// i added a goal as my extra credit, and it saves the goal in the txt file


using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings! You've entered the Journal program.") ;

        JournalEntry storeData = new JournalEntry();
        PromptGenerator prompting = new PromptGenerator();
        JournalData fileName1 = new JournalData();
        while (true)
        {
            Console.WriteLine("Please select one of these: ");
            Console.WriteLine($"1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What's up today? ");  
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (storeData._count == 0)
                {
                    prompting.MoreInfo();
                }
                prompting.PromptsDisplay();
                storeData.SetEntry(prompting._sentence, prompting._prompt, prompting._title, 
                                prompting._author, prompting._goal);
                fileName1.AddEntry(storeData);
            }
            else if (choice == 2)
            {
                fileName1.EntryDisplay();
            }
            else if (choice == 3)
            {

                fileName1.LoadFile();
            }
            else if (choice == 4)
            {
                prompting.Goals();
                storeData.SetEntry(prompting._title,prompting._author, prompting._prompt, prompting._sentence, prompting._goal); //call twice to make sure that the goals are saved into the file
                fileName1.SaveFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("I can't wait to hear from you soon!!\n");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, please select one of the numbers display in the menu \n");
            }
        }
    }
}