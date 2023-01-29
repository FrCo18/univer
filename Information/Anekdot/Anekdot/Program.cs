// See https://aka.ms/new-console-template for more information

namespace Program;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Чтобы пройти собеседование на бухгалтера, ответьте на вопрос:");
        Console.WriteLine("Сколько будет 2x2?");

        while (true)
        {
            for (int i = 1; i <= 4; i++)
            {

                var answer1 = Console.ReadLine();
                answer1 = answer1.ToString();
                if (isTrueTask(answer1))
                {
                    Console.WriteLine("Вы не соответсвуете сценарию анекдота!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Проходит следующий");
                }

            }

            Console.WriteLine("Проходит следующий");
            var answerEnd = Console.ReadLine();
            answerEnd = answerEnd.ToString();
            if (isTrueTask(answerEnd))
            {
                Console.WriteLine("Вы прошли!");
                break;
            }
            else
            {
                Console.WriteLine("Вы не соответсвуете сценарию анекдота!");
            }

        }
    }

    private static bool isTrueTask(string answer)
    {
        answer = answer.ToLower();

        if (answer.Contains("сколько") && (answer.Contains("надо") || answer.Contains("хотите")))
        {
            return true;
        }

        return false;
    }
}
