using System;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Ошибка: деление на ноль");
            return 0;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Улучшенный калькулятор");
        Console.WriteLine($"2 + 3 = {Add(2, 3)}");
        Console.WriteLine($"5 - 2 = {Subtract(5, 2)}");
        Console.WriteLine($"4 * 3 = {Multiply(4, 3)}");
        Console.WriteLine($"10 / 2 = {Divide(10, 2)}");
    }
}