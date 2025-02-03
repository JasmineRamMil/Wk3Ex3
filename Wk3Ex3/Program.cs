using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter a string
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //counter for vowels 
            int vowelCount = 0;

            // convert the input to all lowercase 
            input = input.ToLower();

            //loop to each character to check for vowels
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }
            // Show user total number of vowels 
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);

        }
    }
}
