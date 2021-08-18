using System;
using System.Collections.Generic;
using System.Linq;

namespace SmoothSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;  //Boolean to replay this application
            List<string> noInputs = new List<string> { "no", "n", "nah", "nope" };
            List<string> yesInputs = new List<string> { "yes", "y", "ya", "yeah" };
            Console.WriteLine("A smooth sentence is one where the previous letter of each word is the same as the first letter of the following word.");
            Console.WriteLine("This application will take an input in the form of a sentence and determine whether or not it is a smooth sentence.");
            Console.WriteLine("Please use proper grammar when inputting a sentence. Capitalization does not matter but punctuation does. \nOnly enter one sentence at a time.");

            while (x == true)
            {
                Console.WriteLine("\nPlease enter a sentence");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine("Smooth: " + checkSentence(input));

                Console.WriteLine("\nWould you like to input another?");
                bool z = true;
                while (z == true)
                {
                    string y = Console.ReadLine().ToLower();

                    if (noInputs.Contains(y) || yesInputs.Contains(y))
                    {
                        if (noInputs.Contains(y))
                            x = false;
                        z = false;
                    }
                    else
                        Console.WriteLine("Your input was not recognized. Please try again.");
                }
            }
        }

        public static bool checkSentence(string input)
        {
            bool check = true;
            List<string> words = new List<string>(input.Split(" "));

            for (int i = 0; i < words.Count - 1; i++)
            {
                string currentWord = words[i];
                string nextWord = words[i + 1];

                if (currentWord[currentWord.Length - 1] != nextWord[0])
                    check = false;
            }
            return check;
        }
    }
}
