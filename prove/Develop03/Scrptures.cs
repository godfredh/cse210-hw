using System;
using System.Text;
using System.Collections.Generic;

// Defines a class to represent and manipulate scripture verses.
public class Scripture
{   
    // Private field to store the reference of the scripture.
    private Reference _reference;

    // List to hold all the words of the scripture as Word objects. 
    private List<Word> _listWords = new List<Word>{};

    // List to track the words that remain after some have been hidden; currently not used in this code.
    private List<Word> _remainingWords = new List<Word>{};
    
    // Stores the scripture verse as a string.
    private string _chosenScripture;

    // Constructor that initializes a Scripture object with a verse and its reference.
    public Scripture(string verse, Reference reference)
    {
        _reference = reference; 
        _chosenScripture = verse; 

        // Splits the verse into words and adds them to the lists as Word objects.
        string[] words = _chosenScripture.Split(" "); 
        foreach (string word in words)
        {
            _listWords.Add(new Word(word)); 
            _remainingWords.Add(new Word(word)); 
        }
    }    

    // Determines how many words can be hidden based on the desired number and the current state of word visibility.
    public int NumWordToHide(int numWordToHide) 
    {
        int remainingWords = 0;
         // Count the number of words currently visible.
        for(int k = 0; k < _listWords.Count(); k++)
        {
            // Adjusts the number of words to hide if there are not enough visible words left.
            if (_listWords[k].GetVisibility() == false ) 
            {
                remainingWords++;
            }
        }
        if (remainingWords < numWordToHide)
        {
            numWordToHide = remainingWords;
        }
        if (numWordToHide == 0)
        {
            Environment.Exit(1);
        }
        return numWordToHide;
    }

    // Hides a specified number of words in the scripture.
    public void HideAndShow(int numWordToHide)
    {
        int times = NumWordToHide(numWordToHide);
        Random random = new Random();
        for (int i = 0; i < times; i++)
        {
            // Randomly selects a word to hide, ensuring it's currently visible.
            int index = random.Next(_listWords.Count);
            while(_listWords[index].GetVisibility() == true)
            {
                index = random.Next(_listWords.Count);
            }
            _listWords[index].Hide();
            _listWords[index].Visibility();// The Visibility method is intended for updating or checking visibility, 
            
        }
    }

    // Displays the scripture with hidden words, alongside its reference.
   public void Display()
   {
        StringBuilder stringBuilder =  new StringBuilder();
        // Builds a string representation of the scripture with certain words hidden.
        foreach (Word word in _listWords)
        {
            // Trims the final string and updates the chosen scripture for display.
            stringBuilder.Append(word.Visibility());
            stringBuilder.Append(" ");
        }
        _chosenScripture = stringBuilder.ToString().Trim(); 
        Console.Clear();
        // Prints the scripture reference followed by the scripture text with hidden words.
        Console.WriteLine($"{_reference.GetReference()} {_chosenScripture}");
   }
}