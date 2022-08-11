// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace CharCount
{
    class Program
    {
        static void Main()
        {
            string message = getUserInput().ToUpper();
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            for (int i = 0; i < message.Length; i++)
            {
                char character = message[i];
                if (!charDict.ContainsKey(character))
                {
                    charDict.Add(character, CountInString(message, character));
                }
            }
            foreach (char c in charDict.Keys)
            {
                Console.WriteLine($"{c}: {charDict[c]}");
            }
        }
        static int CountInString(string message, char search)
        {
            int count = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == search)
                {
                    count++;
                }
            }
            return count;
        }
        static string getUserInput()
        {
            string userInput;
            do
            {
                Console.WriteLine("Type in a message and I will count the number of times each character appears.");
                userInput = Console.ReadLine();
            } while (string.IsNullOrEmpty(userInput));
            return userInput;
        }
    }
}