using System;

class Guessing
{
    public static void Main()
    {
        Random rnd = new Random();
        int target_value = rnd.Next(1, 100);
        Console.WriteLine(target_value);
    }
}