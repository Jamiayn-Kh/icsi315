namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Memory memory = new Memory();

        Console.Write("ehnii toog oruul:");
        double n1=Convert.ToDouble(Console.ReadLine());
        Console.Write("hoyrdoh toog oruul:");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("(+,-) operatoriig oruul:");
        char op=Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        double result = 0;
        switch (op)
        {
            case '+':
                result=calc.Add(n1, n2);
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
        memory.AddToMemory(result);
        memory.ShowMemory();
    }
}
