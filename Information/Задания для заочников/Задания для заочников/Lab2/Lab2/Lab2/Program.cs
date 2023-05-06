

class Program
{
    // Шестой вариант
    public static void Main(string[] args)
    {
        Console.WriteLine("Выберите способ решения задания, введите '1' или '2':");


        int solveVariant = getIntVarFromInput();

        switch (solveVariant)
        {
            case 1:
                solveTask1();
                break;
            case 2:
                solveTask2(2);
                break;
            default:
                Console.WriteLine("Такого варианта не существует");
                break;
        }
    }

    private static void solveTask1()
    {
        Console.WriteLine("Введите числа:");
        double a = getDoubleVarFromInput();

        int count = 0;
        if (a >= 0)
        {
            count++;
        }

        a = getDoubleVarFromInput();
        if (a >= 0)
        {
            count++;
        }

        Console.WriteLine("Колличество неотрицательных чисел равно: " + count);
    }

    private static void solveTask2(int countNumbers)
    {
        Console.WriteLine("Введите числа:");
        // заполняем массив с числами
        int count = 0;
        for (int i = 1; i <= countNumbers; i++)
        {
            double a = getDoubleVarFromInput();

            if (a >= 0)
            {
                count++;
            }
        }

        Console.WriteLine("Колличество неотрицательных чисел равно: " + count);
    }

    private static double getDoubleVarFromInput()
    {
        double a;
        if (!Double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Your variable is not double type");
            Console.ReadLine();
            Environment.Exit(0);
        }

        return a;
    }

    private static int getIntVarFromInput()
    {
        int a;
        if (!Int32.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Your variable is not int type");
            Console.ReadLine();
            Environment.Exit(0);
        }

        return a;
    }
}