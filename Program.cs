using System;

class Program
{
    static void Main(string[] args)
    {
        int result = Square(5);
        Console.WriteLine("Square: " + result);

        string message = BuildMessage("Sam");
        Console.WriteLine(message);

        PrintTotal(3, 4);
    }

    static int Square(int n)
    {
      return  n * n;
    }

    static string BuildMessage(string name)
    {
        return "Hello " + name;
    }

    static void PrintTotal(int a, int b)
    {
        int total = a + b;
        return total;
    }
}