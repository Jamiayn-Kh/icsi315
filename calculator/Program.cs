namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Memory memory = new Memory();

        double result1 = calc.Add(7, 2);
        Console.WriteLine($"Add: 7 + 2 = {result1}");
        memory.AddToMemory(result1);

        double result2 = calc.Subtract(15, 5);
        Console.WriteLine($"Subtract: 15 - 5 = {result2}");
        memory.AddToMemory(result2);

        memory.ShowMemory();
    }
}
