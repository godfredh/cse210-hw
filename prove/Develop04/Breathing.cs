public class Breathing : Activity
{

        private  string _breathIn;
        //contain the _breath in...string
        private string _breathOut;
        //contain the _breath out...string
        public Breathing(string name, string description, int time = 0) : base (name, description)
        //Inherit from the base
        {
            // Initializing the breath in and breath out strings
            _breathIn = "Breath in...";
            _breathOut = "Breath out...";
        } 

        // Method to perform the breathing in and out activity
        public void InAndOut()
        //Display the process of the activity
        {
            // Check if the time spent is greater than or equal to 10 seconds
            if (_timeSpent >= 10)
            {
                // Calculate the number of times the breathing cycle needs to be repeated
                int times = base._timeSpent / 10;

                // Loop through the breathing cycle for the calculated times
                for (int i = 0; i < times; i++)
                {
                    // Display breath in message and countdown timer
                    Console.WriteLine();
                    Console.Write(_breathIn);
                    base.GetCountDownTimer();
                    Console.WriteLine();

                    // Display breath out message and countdown timer
                    Console.Write(_breathOut);
                    base.GetCountDownTimer();
                    Console.WriteLine();
                }
            }
            else
            {
                // If time spent is less than 10 seconds, perform the breathing cycle once
                for (int i = 0; i < 1; i++)
                {
                    // Display breath in message and countdown timer
                    Console.WriteLine();
                    Console.Write(_breathIn);
                    base.GetCountDownTimer();
                    Console.WriteLine();

                    // Display breath out message and countdown timer
                    Console.Write(_breathOut);
                    base.GetCountDownTimer();
                    Console.WriteLine();
                }
            }
        }
}  