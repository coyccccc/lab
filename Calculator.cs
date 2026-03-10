using System;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static void Main()
    {
        Console.WriteLine("Калькулятор запущен");
        Console.WriteLine($"2 + 3 = {Add(2, 3)}");
    }
}
