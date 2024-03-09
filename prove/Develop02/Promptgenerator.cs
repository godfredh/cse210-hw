public class PromptGenerator
{
    public string _title;
    public string _sentence;
    public string _prompt;
    public string _author;
    public string _goal;
    public List<string> _promptsList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public void PromptsDisplay()
    // a method that will print the current time and date and also generate 
    // a random string from the list
    {
        var date = new DateTime(); //get the date and time
        date = DateTime.Now; //get the current date and time

        var random = new Random(); //generate the random method
        int index = random.Next(_promptsList.Count()); //get the total of string in the list and store it as index
        _prompt = _promptsList[index]; // select a random string from the list and store it into the variable

        Console.Write($"{_prompt}\n>");

        _sentence = Console.ReadLine();
    }
    public void MoreInfo() //create a title and the name of the person writing.
    {

        Console.Write("Summarize your day in two to three words.\nPlease note!! that this will be used as the section title: ");
        _title = Console.ReadLine();

        Console.Write("Please input your name to capture the author's information: ");
        _author = Console.ReadLine();
    }
    public string Goals()
    {
        //entice the user to set goals and track his progression
        Console.WriteLine("\nEstablish a goal that you plan to focus on either this week or this month,");
        Console.WriteLine("then you can record your progression. what would you like to do?");
        Console.Write("1. Generate a fresh goal\n2. Document my progress\n3. None of the options mentioned:\n>");
        int decision = int.Parse(Console.ReadLine());
        if (decision == 1)
        {
            Console.Write("What is your goal: \n");
            _goal = Console.ReadLine().ToUpper();
            return _goal;
        }
        else if (decision == 2)
        {
            Console.Write("Any progress on your goal? (Yes(Y)/No(N)): ");
            string progress = Console.ReadLine().ToUpper();
            if (progress == "Y")
            {
                Console.Write("How much progress have you made with your goal?: \n");
                _goal = Console.ReadLine();
            } 
            else if (progress == "N")
            {
                Console.Write("What changes will you implement this time to achieve your goal?: \n");
                _goal = Console.ReadLine();
            }    
            return _goal;

        }
        else if (decision == 3)
        {
            Console.WriteLine("Certainly, and always remember, goals propel you forward. ");
            return null;
        }
        else
        {
            Console.WriteLine("Invalid input");
            return null;
        }
    }
}