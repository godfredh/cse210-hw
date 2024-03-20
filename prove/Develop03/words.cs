using System;

public class Word
{
    // Field to track whether the word is hidden.
    private bool _hidden = false;
    
    // The word itself stored as a string.
    private string _word;
    
    // Constructor to initialize a Word object with a given string.
    public Word (string word) {
        _word = word;
    } 

    // Method to hide the word. Sets _hidden to true and returns the new state
    public bool Hide() 
    {
        
        return _hidden = true;
    }

    // Method to check if the word is hidden or visible.
    public bool GetVisibility()
    {
        return _hidden;
    }

    // Method to get a representation of the word's current state: hidden or visible.
    public string Visibility()
    {

        // If the word is hidden, returns a string of underscores ('_') with the same length as the word.
        if (_hidden)
        {
            return new string('_', _word.Count()); // Using Length instead of Count() as it's more appropriate for strings.
        }
        else
        {
            return _word; // If the word is not hidden, returns the word itself

        }
    }
}