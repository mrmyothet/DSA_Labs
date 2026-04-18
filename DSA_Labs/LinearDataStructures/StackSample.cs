using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures;

public class StackSample
{
    public static void Run()
    {
        // Declare and initialize a stack
        Stack<string> undoHistory = new Stack<string>();
        undoHistory.Push("Entered 5 + 3");
        undoHistory.Push("Entered 10 - 2");
        undoHistory.Push("Entered 7 * 4");
        undoHistory.Push("Entered 20 / 5");
        undoHistory.Push("Entered 3 ^ 2");

        // Print the stack
        Console.WriteLine("Undo History:");
        foreach (string action in undoHistory)
        {
            Console.WriteLine(action);
        }

        // Pop an element
        Console.WriteLine("\nUndoing Action: " + undoHistory.Pop());
        // Print the updated stack
        Console.WriteLine("\nUpdated Undo History:");
        foreach (string action in undoHistory)
        {
            Console.WriteLine(action);
        }
    }
}
