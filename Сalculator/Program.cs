namespace Сalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение:");
            string x1 = Console.ReadLine();

            if (!int.TryParse(x1, out int x))
            {
                Console.WriteLine("Значение набранно некорректно.");
                return;
            }

            Console.WriteLine("Введите второе значение:");
            string y1 = Console.ReadLine();
            if (!int.TryParse(y1, out int y))
            {
                Console.WriteLine("И что теперь, будем складывать буквы?");
                return;
            }
      
            Console.WriteLine("Выберите действие: +, -, *, /.");
            string mathAction = Console.ReadLine();
            if (mathAction != "+" && mathAction != "-" && mathAction != "*" && mathAction != "/")
            {
                Console.WriteLine("Я пока не умею так считать.");
                return;
            }
           
            if (y == 0 && mathAction == "/") 
            {
                Console.WriteLine("Шарик, ты балбес! На ноль делить нельзя.");
                return;
            }
             
            Count(x, y, mathAction);
        }

        static void Count(int x, int y, string mathAction)
        {
            
            switch (mathAction)
            {
                case ("+"):
                    int a = x + y;
                    Console.WriteLine($"{a}");
                    break;
                case ("-"):
                    int b = x - y;
                    Console.WriteLine($"{b}");
                    break;
                case ("*"):
                    int c = x * y;
                    Console.WriteLine($"{c}");
                    break;
                case ("/"):
                    int d = x / y;
                    Console.WriteLine($"{d}");
                    break;

            }

        }
    }
}
