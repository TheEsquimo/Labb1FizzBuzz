using System;

namespace Labb1FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FizzBuzzRun();
        }

        public int UserInput()
        {
            int inputNumber = 0;
            while (inputNumber < 1 || inputNumber >= 300)
            {
                Console.WriteLine("Pick a number between 1-299:");
                string input = Console.ReadLine();
                try
                {
                    inputNumber = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }
                
            return inputNumber;
        }

        public void FizzBuzzRun()
        {
            while (true)
            {
                var userInput = UserInput();
                Console.Clear();
                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine(GetFizzBuzzResult(i));
                }

                Console.ReadKey();
            }
        }
        
        public string GetFizzBuzzResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number == 42)
            {
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            return number.ToString();
        }
    }
}
