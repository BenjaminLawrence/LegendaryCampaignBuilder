using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    internal class OutputHandler
    {
        public string SimpleMenu(string question, string[] options)
        {
            // Check that there is a question
            if (question == null)
            {
                throw new ArgumentNullException("No question");
            }
            // Check that there are options
            if (options == null)
            {
                throw new ArgumentNullException("No options");
            }
            // Start the menu loop
            bool repeat = true; ;
            int choice = -1;
            do
            {
                // Ask the question
                Console.WriteLine(question);
                // Give options
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + options[i]);
                }
                // Get user input
                string input = Console.ReadLine();
                // Check if the input is empty
                if (input != null)
                {
                    // Attempt to convert input to integer
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        // Adjust the option to match the array
                        choice--;
                        // Check that the choice is in the range
                        if (choice >= 0 || choice < options.Length)
                        {
                            repeat = false;
                        }
                        // Deal with choices out of range
                        else
                        {
                            Console.WriteLine("Error: Please choose one of the available options");
                        }
                    }
                    // Deal with non-integer input
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Input must be an integer");
                    }
                }
                // Deal with empty input
                else
                {
                    Console.WriteLine("Error: Input cannot be blank");
                }
            } while (repeat);
            return options[choice];
        }
    }
}
