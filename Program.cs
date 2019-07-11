using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // an object in C# as a Dictionary.

            Dictionary<string, int> toysSold = new Dictionary<string, int>() {
    {"Hot Wheels", 344},
    {"Legos", 763},
    {"Gaming Consoles", 551},
    {"Board Games", 298}
};
            //add a toy
            toysSold.Add("Bicycles", 87);

            //f you want to see all the toys and how many were sold, you can 
            //use a foreach to iterate over all of the KeyValuePair items in the dictionary.

            foreach (KeyValuePair<string, int> toy in toysSold)
            {
                Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            }
        }
    }
}
