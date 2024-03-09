using System;
public class JournalEntry   // Count of journal entries
{
   
   // Properties for the journal entry
    public int _count = 0;
    public string _prompt;
    public string _answer;
    public string _date; 
    public string _title;
    public string _author;
    public string _goal;
    
    // Method to set the values of a journal entr
    public void SetEntry(string title,string author, string prompt,string answer, string goal)
    {
        _prompt = prompt;
        _answer = answer;
        _title = title;
        _author = author;
        _goal = goal;
        _date = DateTime.Now.ToString();

    }

     // Method to get the formatted entry as a string
    public string GetEntry()
    {
        return ($"Title - {_title}\n" +
                $"By - {_author}\n" +
                $"Prompt - {_prompt}\n" +
                $"Answer - {_answer}\n" +
                $"GOAL - {_goal}\n" +
                $"Date and time - {_date}\n");
    }

     // Method to display the journal entry
    public void Display()
    {
        Console.WriteLine(GetEntry());
    }
}