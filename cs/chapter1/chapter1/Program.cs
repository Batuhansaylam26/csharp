using System;
class Program
{
    //there is no importance of location of main method
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Hello");
        Console.WriteLine("World");
        Console.WriteLine(3 + 4 + 5);
        Console.WriteLine(account());
        Console.WriteLine(account2());
        Console.WriteLine(len());

    }
    static float account()
    {
        float balance = 100000.00f;
        float interest_rate = 0.05f;
        for (int i = 1; i < 5; i++)
        {
            float interest = balance * interest_rate;
            balance += interest;

        }
        return balance;
    }

    static double account2()
    {
        double balance = 100000.00;
        double interest_rate = 0.05;
        for (int i = 1; i < 5; i++)
        {
            double interest = balance * interest_rate;
            balance += interest;

        }
        return balance;
    }
    static int len()
    {
        string name = "Batuhan SAYLAM";
        return name.Length;
    }
/*
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Hello");
        Console.WriteLine("World");
        Console.WriteLine(3 + 4 + 5);
        Console.WriteLine(account());
        Console.WriteLine(account2());

    }
*/
}