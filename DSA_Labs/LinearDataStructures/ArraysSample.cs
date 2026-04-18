using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures;

public class ArraysSample
{
    public static void Run()
    {
        // Declare and initialize an array of calculator inputs
        string[] inputHistory = { "5 + 3", "10 - 2", "7 * 4", "20 / 5", "3 ^ 2" };

        // Print the original input history
        Console.WriteLine("Original Calculator Input History:");
        foreach (string input in inputHistory)
        {
            Console.WriteLine(input);
        }

        // Modify an entry (change "10 - 2" to "10 / 2")
        inputHistory[1] = "10 / 2";

        // Print the updated input history
        Console.WriteLine("\nUpdated Calculator Input History:");
        foreach (string input in inputHistory)
        {
            Console.WriteLine(input);
        }
    }
}
