using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Three Basic Arrays:

            // Create an array to hold integer values 0 through 9
            int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            // Create an array of length 10 that alternates between true and false values, starting with true
            int[] arr2 = new int[10];
            for (int i = 1; i <= 10; i++) {
                if(i %2 == 0) {
                    Console.Write("false");
                } else {
                    Console.Write("true");
                }
            }

            // List of Flavors:

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("choco-chip");
            flavors.Add("mint");
            flavors.Add("strawberry");
            flavors.Add("oreo");

            // Output the length of this list after building it
            Console.WriteLine($"Length of list: {flavors.Count}.");

            // Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);

            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"{flavors.Count}.");


            // User Info Dictionary:

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> profile = new Dictionary<string,string>();

            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            profile.Add("Tim", "vanilla");
            profile.Add("Martin", "choco-chip");
            profile.Add("Nikki", "mint");
            profile.Add("Sara", "strawberry");

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string,string> entry in profile) {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
            
        }
    }
}
