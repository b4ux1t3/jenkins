using System;
using System.Collections.Generic;

namespace Jenkins
{
    /// <summary>
    /// Just a silly little program that adds something to your name, then counts the chgaracters in your name. Made to teach basics of dictionaries.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Counts each character in a string.
        /// </summary>
        /// <param name="input">Must be a string. Any string.</param>
        /// <returns>A dictionary of counted characters; non-used characters are not included in the output</returns>
        static Dictionary<char, int> countLetters(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            foreach (char c in input)
            {
                try
                {
                    counts[c]++;
                }
                catch
                {
                    counts.Add(c, 1);
                }
            }

            return counts;

        }

        /// <summary>
        /// Looks through the dictionary and pulls out the highest char, int combination.
        /// </summary>
        /// <param name="dict">Any dict with char, int config</param>
        /// <returns>Highest int value</returns>
        static KeyValuePair<char, int> findHighest(Dictionary<char, int> dict)
        {
            char highestChar = ' ';
            int highestCount = 0;
            

            foreach (KeyValuePair<char, int> kvp in dict)
            {
                if (kvp.Value > highestCount)
                {
                    highestCount = kvp.Value;
                    highestChar = kvp.Key;
                }
            }
            KeyValuePair<char, int> highest = new KeyValuePair<char, int>(highestChar, highestCount);

            return highest;
        }

        static void Main(string[] args)
        {
            string name;
            string output;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            output = name + " Jenkins";
            Console.WriteLine("Your new name is: " + output + "!");
            Console.WriteLine("Your name is " + output.Length + " characters long.");

            Dictionary<char, int> counts = new Dictionary<char, int>(countLetters(output));

            KeyValuePair<char, int> highest = findHighest(counts);

            Console.WriteLine("The most-used character in your name is {0}, which was used {1} times.", highest.Key, highest.Value);
            Console.Read();
        }
    }
}
