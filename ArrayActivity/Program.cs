using System;
using ArrayClassLibrary;

namespace ArrayActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Welcome to the Activity Center ===");
                Console.WriteLine("[1] Array Manipulation");
                Console.WriteLine("[2] Linear Search Task");
                Console.WriteLine("[3] String Reversal");
                Console.WriteLine("[4] String Split And Count");
                Console.WriteLine("[5] Exit Program");
                Console.Write("\nSelect (1-5): ");
                string choice = Console.ReadLine();

                ActivityBase activity;

                switch (choice)
                {
                    case "1":
                        activity = new ArrayManipulation();
                        break;
                    case "2":
                        activity = new LinearSearchTask();
                        break;
                    case "3":
                        activity = new StringReversal();
                        break;
                    case "4":
                        activity = new StringSplitAndCount();
                        break;
                    case "5":
                        activity = null;
                        break;
                    default:
                        activity = null;
                        break;
                }

                if (activity == null)
                {
                    if (choice == "5")
                    {
                        Console.WriteLine("\nThank you. Goodbye!");
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice.");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                    }
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"--- Running Activity {choice} ---\n");
                activity.Run();

                Console.WriteLine("\nActivity complete. Press any key to return to the menu.");
                Console.ReadKey();
            }
        }
    }
}