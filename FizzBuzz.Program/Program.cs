using System;

namespace FizzBuzz.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of FizzBuzz! Enter how many numbers you want a solution for:");

            var input = Console.ReadLine();

            if (!int.TryParse(input, out var numbers))
            {
                Console.WriteLine($"{input} is not a number");
                return;
            }

            var fizzBuzz = new FizzBuzzLogic();

            for (var i = 1; i <= numbers; i++)
            {
                var wordToPrint = fizzBuzz.FizzBuzzWordGenerator(i);
                Console.WriteLine($"{i}: {wordToPrint}");
            }
        }
    }
}