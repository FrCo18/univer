class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input 3 double numbers:");
        double a = getVarFromInput();
        double b = getVarFromInput();
        double c = getVarFromInput();

        Console.WriteLine("Task result: " + solveTask(a, b, c));
    }

    // Шестой вариант
    private static double solveTask(double a, double b, double c)
    {
        double firstStep = a - 2 * Math.Pow(Math.Sin(b), 3);
        double secondStep = a * (Math.Tan(c) + b);
        return firstStep / secondStep;
    }

    private static double getVarFromInput()
    {
        double a;
        if (!Double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Your variable is not double type");
            Console.WriteLine("Programm ended.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        return a;
    }
}