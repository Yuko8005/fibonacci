using System;

class Program
{
    static void Main()
    {
        int n = 40;
        PrintFibonacciNumbers(n);
    }

    static void PrintFibonacciNumbers(int n)
    {
        int a = 0;
        int b = 1;

        Console.WriteLine("Перші {0} чисел Фібоначчі:", n);
        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}
