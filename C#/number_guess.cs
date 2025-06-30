using System;

class Guessing
{
    public static void Main(String[] args)
    {
        Random rnd = new Random();
        int target_value = rnd.Next(1, 100);
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("Guess the number between 1 and 100: ");
        String input = Console.ReadLine();
        int guess_value = 0;
        int.TryParse(input, out guess_value);
        int no_attempts = 0;

        while(target_value != guess_value)
        {
            int guess_factor = target_value - guess_value;

            if(guess_factor>0 && guess_factor>10)
            {
                Console.WriteLine("Wrong guessing, lower and far");
                Console.WriteLine("Guess again: ");
                input = Console.ReadLine();
                int.TryParse(input, out guess_value);
                no_attempts++;
            }
            if (guess_factor > 0 && guess_factor < 10)
            {
                Console.WriteLine("Wrong guessing, lower but close");
                Console.WriteLine("Guess again: ");
                input = Console.ReadLine();
                int.TryParse(input, out guess_value);
                no_attempts++;
            }
            if (guess_factor < 0 && guess_factor > 10)
            {
                Console.WriteLine("Wrong guessing, higher and far");
                Console.WriteLine("Guess again: ");
                input = Console.ReadLine();
                int.TryParse(input, out guess_value);
                no_attempts++;
            }
            if (guess_factor < 0 && guess_factor < 10)
            {
                Console.WriteLine("Wrong guessing, higher and close");
                Console.WriteLine("Guess again: ");
                input = Console.ReadLine();
                int.TryParse(input, out guess_value);
                no_attempts++;
            }
        }
        Console.WriteLine("Correct guessing it took you "+ no_attempts + "times");
    }
}