

class Program
{
    private const int FIRST_EL = 4;
    // Восьмой вариант вариант
    public static void Main(string[] args)
    {
        Console.WriteLine("Дано начало последовательности: 4, 14, 44, 134, 404, ...");
        Console.WriteLine("Какой элемент последовательности вы хотите получить?");
        Console.WriteLine("Введите номер этого элемента:");

        int elNumber = getIntVarFromInput();
        if (elNumber < 1)
        {
            Console.WriteLine("Индекс элемента не может быть меньше 1");
            Console.ReadKey();
            return;
        }

        int resultNumber = getNumberByIndex(elNumber);

        Console.WriteLine($"Число под индексом {elNumber} равно: {resultNumber}");
        Console.ReadKey();
    }

    private static int getNumberByIndex(int index)
    {
        int resultNumber = FIRST_EL;
        for (int i = 1; i < index; i++)
        {
            resultNumber = 3 * resultNumber + 2;
        }

        return resultNumber;
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