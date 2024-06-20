using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (!double.TryParse(Console.ReadLine(), out double firstNumber))
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        if (!double.TryParse(Console.ReadLine(), out double secondNumber))
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
            return;
        }

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Введенные числа равны.");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }
    }
}
