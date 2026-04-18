using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures;

public class LinkedListSample    {
    public static void Run()
    {
        // Declare and initialize a linked list
        LinkedList<string> results = new LinkedList<string>();
        results.AddLast("Result: 8");
        results.AddLast("Result: 5");
        results.AddLast("Result: 28");
        results.AddLast("Result: 4");
        results.AddLast("Result: 9");

        // Print the linked list
        Console.WriteLine("Calculation Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        // Remove an element
        results.Remove("Result: 5");

        // Print the updated linked list
        Console.WriteLine("\nUpdated Calculation Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}
