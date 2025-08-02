using System;

namespace Mikayil_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select a task:");
            Console.WriteLine("1. Task 1 (Algorithm tasks)");
            Console.WriteLine("2. Task 2 (Question tasks)");
            Console.WriteLine("3. Exit program");
            Console.Write("\nEnter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Task1Menu();
                    return true;
                case "2":
                    Task2();
                    return true;
                case "3":
                    return false;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter a valid number.");
                    Console.ReadKey();
                    return true;
            }
        }

        private static void Task1Menu()
        {
            bool showTask1Menu = true;
            while (showTask1Menu)
            {
                Console.Clear();
                Console.WriteLine("--- Task 1: Algorithm Tasks ---");
                Console.WriteLine("1. Check number (> 7)");
                Console.WriteLine("2. Check name (John)");
                Console.WriteLine("3. Find multiples of 3 in an array");
                Console.WriteLine("4. Go Back");
                Console.Write("\nEnter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CheckNumber();
                        break;
                    case "2":
                        CheckName();
                        break;
                    case "3":
                        CheckArray();
                        break;
                    case "4":
                        showTask1Menu = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a valid number.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void CheckNumber()
        {
            Console.Clear();
            Console.WriteLine("--- Check Number (> 7) ---");
            Console.WriteLine("Type 'exit' or 'q' to go back.");

            while (true)
            {
                Console.Write("\nPlease enter a number: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q" || input.ToLower() == "exit")
                {
                    break;
                }

                string standardizedInput = input.Replace(',', '.');

                if (double.TryParse(standardizedInput, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double number))
                {
                    if (number > 7)
                    {
                        Console.WriteLine("Result: Hello");
                    }
                    else if (number == 7)
                    {
                        Console.WriteLine("Result: The entered number is equal to 7.");
                    }
                    else
                    {
                        Console.WriteLine("Result: The entered number is not greater than 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Result: Invalid input. Please enter a valid number.");
                }
            }
        }

        private static void CheckName()
        {
            Console.Clear();
            Console.WriteLine("--- Check Name (John) ---");
            Console.WriteLine("Type 'exit' or 'q' to go back.");

            while (true)
            {
                Console.Write("\nPlease enter a name: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q" || input.ToLower() == "exit")
                {
                    break;
                }

                if (input.Equals("John", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Result: Hello, John");
                }
                else
                {
                    Console.WriteLine("Result: There is no such name");
                }
            }
        }

        private static void CheckArray()
        {
            Console.Clear();
            Console.WriteLine("--- Find Multiples of 3 ---");
            Console.WriteLine("Please enter integers separated by commas or spaces (e.g., 1,2,3,4,5,6 or 1 2 3 4 5 6)");
            Console.WriteLine("Type 'exit' or 'q' to go back.");

            while (true)
            {
                Console.Write("\nvalues: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q" || input.ToLower() == "exit")
                {
                    break;
                }

                string[] numberStrings = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("Numbers that are multiples of 3:");

                bool foundMultipleOf3 = false;
                foreach (string s in numberStrings)
                {
                    string trimmedValue = s.Trim();
                    if (int.TryParse(trimmedValue, out int num))
                    {
                        if (num % 3 == 0)
                        {
                            Console.WriteLine(num);
                            foundMultipleOf3 = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value: {trimmedValue}");
                    }
                }

                if (!foundMultipleOf3)
                {
                    Console.WriteLine("No numbers divisible by 3 were found in the input.");
                }
            }
        }

        private static void Task2()
        {
            Console.Clear();
            Console.WriteLine("--- Task 2: Question Tasks ---");
            Console.WriteLine("Given bracket sequence: [((())()(())]]");
            Console.WriteLine("\nCan this sequence be considered correct? No.");
            Console.WriteLine("What needs to be changed to make it correct? The extra ']' bracket at the end must be removed.");
            Console.WriteLine("Correct version: [((())()(()))]");
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
