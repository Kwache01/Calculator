using System;

class Program
{
    static void Main(string[] args)
    {
        int action;
        do
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            action = Convert.ToInt32(Console.ReadLine());

            double a, b, result;
            switch (action)
            {
                case 1:
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case 2:
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case 3:
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case 4:
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine("Результат: " + result);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите число и степень:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(a, b);
                    Console.WriteLine("Результат: " + result);
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (a >= 0)
                    {
                        result = Math.Sqrt(a);
                        Console.WriteLine("Результат: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Квадратный корень из отрицательного числа не определен!");
                    }
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    result = a / 100;
                    Console.WriteLine("Результат: " + result);
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (a >= 0 && a == (int)a)
                    {
                        result = Factorial((int)a);
                        Console.WriteLine("Результат: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Факториал определен только для неотрицательных целых чисел!");
                    }
                    break;
                case 9:
                    Console.WriteLine("Выход из программы");
                    break;
                default:
                    Console.WriteLine("Неверное действие, попробуйте еще раз");
                    break;
            }
        } while (action != 9);
    }

    static int Factorial(int number)
    {
        int fact = 1;
        for (int i = 2; i <= number; i++)
        {
            fact *= i;
        }
        return fact;
    }
}