using System;
class Program
{
    //there is no importance of location of main method
    static void Main(string[] args)
    {
        Console.WriteLine(len());
        Console.WriteLine(UpperCase());
        Console.WriteLine(ReplaceString());
    }
    static int len()
    {
        string name = "Batuhan SAYLAM";
        return name.Length;
    }
    static string UpperCase()
    {
        string name = "Batuhan SAYLAM";
        return name.ToUpper();
    }
    static string ReplaceString()
    {
        string name = "Batuhan SAYLAM";
        return name.Replace("Batuhan","Yafes");
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