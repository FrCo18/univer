

class Program
{
    // 10 вариант
    public static void Main(string[] args)
    {
        Console.WriteLine("Дано начало последовательности: 4, 14, 44, 134, 404, ...");
        Console.WriteLine("Какой элемент последовательности вы хотите получить?");
        Console.WriteLine("Введите номер этого элемента:");

        Console.WriteLine("Введите переменную a");
        double a = getDoubleVarFromInput();

        Console.WriteLine("Введите переменную b");
        double b = getDoubleVarFromInput();

        Console.WriteLine("Введите переменную c");
        double c = getDoubleVarFromInput();
       
        double resultTask = solveByFormula(a, b, c);

        Console.WriteLine($"Результат решения формулы под вариантом 10: {resultTask}");
        Console.ReadKey();
    }

    private static double solveByFormula(double a, double b, double c)
    {
        double numerator = Math.Sqrt(b + Math.Pow(Math.Cos(a), 2)) + Math.Pow(2.71828, c);
        double denominator = Math.Abs(a + b + c);

        return numerator / denominator;
    }

    private static double getDoubleVarFromInput()
    {
        double a;
        while (!Double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Your variable is not double type");
            Console.WriteLine("Please input again");
        }

        return a;
    }
}