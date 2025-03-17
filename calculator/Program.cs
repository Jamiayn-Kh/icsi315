using CalculatorLibrary;

namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        // Change this line to use the Calculator from CalculatorLibrary
        CalculatorLibrary.Calculator calc = new CalculatorLibrary.Calculator();

        Console.Write("ehnii toog oruul:");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("hoyrdoh toog oruul:");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("(+,-) operatoriig oruul:");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;
        switch (op)
        {
            case '+':
                result = calc.Add(n1, n2);
                Console.WriteLine($"niilber: {n1}+{n2}={result}");
                break;
            case '-':
                result = calc.Subtract(n1, n2);
                Console.WriteLine($"yalgavar: {n1}-{n2}={result}");
                break;
            default:
                Console.WriteLine("buruu utga");
                return;
        }

        // Store result in memory
        calc.StoreInMemory(result);
        Console.WriteLine($"Result stored in memory: {calc.RecallMemory()}");

        // Show memory operations menu
        Console.WriteLine("\nMemory Operations:");
        Console.WriteLine("1. Add to memory");
        Console.WriteLine("2. Subtract from memory");
        Console.WriteLine("3. Clear memory");
        Console.WriteLine("4. Exit");

        Console.Write("Select an operation: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Enter value to add to memory: ");
                    if (double.TryParse(Console.ReadLine(), out double addValue))
                    {
                        calc.AddToMemory(addValue);
                        Console.WriteLine($"New memory value: {calc.RecallMemory()}");
                    }
                    break;
                case 2:
                    Console.Write("Enter value to subtract from memory: ");
                    if (double.TryParse(Console.ReadLine(), out double subtractValue))
                    {
                        calc.SubtractFromMemory(subtractValue);
                        Console.WriteLine($"New memory value: {calc.RecallMemory()}");
                    }
                    break;
                case 3:
                    calc.ClearMemory();
                    Console.WriteLine("Memory cleared");
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}