using System;

namespace Labb1FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                var userInput = program.UserInput(new ReadConsole());
                Console.Clear();

                program.FizzBuzzRun(userInput);

                Console.WriteLine("Press any button to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public int UserInput(IConsole console)
        {
            int inputNumber = 0;
            while (inputNumber < 1 || inputNumber >= 300)
            {
                Console.WriteLine("Pick a number between 1-299:");
                string input = console.ReadLine();
                try
                {
                    inputNumber = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return inputNumber;
        }

        public void FizzBuzzRun(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(GetFizzBuzzResult(i));
            }
        }
        
        public string GetFizzBuzzResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number == 42)
            {
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
