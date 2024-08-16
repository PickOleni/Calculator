using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Сalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isUserWannaContinue = true;
            while (isUserWannaContinue)
            {
                Console.WriteLine("Введите первое значение:");

                int number1 = Input("Значение набранно некорректно.");
                Console.WriteLine("Введите второе значение:");
                int number2 = Input("И что теперь, будем складывать буквы?");

                Console.WriteLine("Выберите действие: +, -, *, /.");
                string mathAction = Console.ReadLine();

                if (number2 == 0 && mathAction == "/")
                {
                    Console.WriteLine("Шарик, ты балбес! На ноль делить нельзя.");
                    continue;
                }

                Count(number1, number2, mathAction);

                string hotkeyForExit = "н";
                Console.WriteLine($"Если хотите закончить - введите {hotkeyForExit}");
                string programmRepeat = Console.ReadLine();

                if (programmRepeat == hotkeyForExit)
                {
                    isUserWannaContinue = false;
                    Console.WriteLine("До скорых встреч!");
                    return;
                }
            }
        }

        static int Input(string errorText)
        {
            string inputNumber = Console.ReadLine();

            if (!int.TryParse(inputNumber, out int number))
            {
                Console.WriteLine($"{errorText}");
            }
            return number;
        }

        static void Count( int number1, int number2, string mathAction)
        {

            int answer = 0;
            
            switch (mathAction)
            {
                case ("+"):
                    answer = number1 + number2;
                    Console.WriteLine($"{answer}");
                    break;
                case ("-"):
                    answer = number1 - number2;
                    Console.WriteLine($"{answer}");
                    break;
                case ("*"):
                    answer = number1 * number2;
                    Console.WriteLine($"{answer}");
                    break;
                case ("/"):
                    answer = number1 / number2;
                    Console.WriteLine($"{answer}");
                    break;
                default:
                    Console.WriteLine("Я пока не умею так считать.");
                    break;

            }

        }
    }
}
