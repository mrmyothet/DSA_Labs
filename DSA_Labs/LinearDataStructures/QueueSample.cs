using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures;

public class QueueSample
{
    public static void Run()
    {

        // Declare and initialize a queue
        Queue<string> pendingCalculations = new Queue<string>();
        pendingCalculations.Enqueue("Calculate: 15 + 5");
        pendingCalculations.Enqueue("Calculate: 12 - 3");
        pendingCalculations.Enqueue("Calculate: 9 * 2");
        pendingCalculations.Enqueue("Calculate: 16 / 4");
        pendingCalculations.Enqueue("Calculate: 2 ^ 3");

        // Print the queue
        Console.WriteLine("Pending Calculations:");
        foreach (string calculation in pendingCalculations)
        {
            Console.WriteLine(calculation);
        }

        // Dequeue an element
        Console.WriteLine("\nProcessing Calculation: " + pendingCalculations.Dequeue());

        // Print the updated queue
        Console.WriteLine("\nUpdated Pending Calculations:");
        foreach (string calculation in pendingCalculations)
        {
            Console.WriteLine(calculation);
        }
    }
}
