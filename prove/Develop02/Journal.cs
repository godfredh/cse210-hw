using System.Collections.Generic;
public class JournalData
{

    public string _fileName;
    public string _fileFormat;
    public string _format;
    public string _data;
    public List<JournalEntry> _entries = new List<JournalEntry>{};
    //create, save and add if the file exist in the path or
    //write in that file

    public void EntryDisplay()
    {
        foreach (JournalEntry data in _entries)
        {
           data.Display();
        }
    }
     public void AddEntry(JournalEntry entries)
    {
        _entries.Add(entries);

    }

    public void SaveFile() // Save journal entries to a file
    {
        Console.Write("What type of file is it(CSV or TXT)?\n>");
        _fileName = Console.ReadLine();
        Console.Write("Please enter the file format, CSV or TXT: ");
        _format = Console.ReadLine().ToLower();

         // Validate file format
         if (_format == "txt" || _format == "csv")
        {
            _fileFormat = $"{_fileName}.{_format}"; // Use lowercase format for file type
        }
        else
        {
            Console.WriteLine("Invalid file format. Please enter CSV or TXT.");
            return;
        }

        // Write entries to the specified file
        using (StreamWriter out_put_file = new StreamWriter(_fileFormat))
        {
            foreach (JournalEntry data in _entries)
            {
                out_put_file.WriteLine($"{data.GetEntry()}");
            }
        }
    }

    public void LoadFile()  // Load journal entries from a file
    {
        // Prompt user for file information
        Console.Write("Enter the Name of the file: \n");
        _fileName = Console.ReadLine();
        Console.Write("Please enter the file format, CSV or TXT: ");
        _format = Console.ReadLine().ToLower();

        // Validate file format
        if (_format == "txt" || _format == "csv")
        {
            _fileFormat = $"{_fileName}.{_format}"; // Use lowercase format for file type
        }
        else
        {
            Console.WriteLine("Invalid file format. Please enter CSV or TXT. ");
            return;
        }

        // Read entries from the specified file
        string[] lines = File.ReadAllLines(_fileFormat);
        _entries.Clear();

        while (lines.Length > 0)
        {
            List<string> content = new List<string> { };
            for (int i = 0; i < 6; i++)
            {
                string[] data = lines[i].Split("-");
                content.Add(data[1]);
            }
            JournalEntry load = new JournalEntry();
            load.SetEntry(content[0], content[1], content[2], content[3], content[4]);
            load._date = content[5];
            lines = lines.Skip(7).ToArray();
            _entries.Add(load);
            content.Clear();
        }
    }
}