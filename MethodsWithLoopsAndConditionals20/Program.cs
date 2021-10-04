using System;

namespace MethodsWithLoopsAndConditionals20
{
    class Program
    {
        static void Main(string[] args)
        {
            //            LukeWarm Section:
            //1. Write a method that will print to the console all numbers 1000 through - 1000.
            //2. Write a method that will print to the console numbers 3 through 999 by 3 each time.
            //3. Write a method to accept two integers as parameters and check whether they are equal or not.
            //4. Write a method to check whether a given number is even or odd.
            //5. Write a method to check whether a given number is positive or negative.
            //6. Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!


            OneThousand();
            //PrintBy3();
            //CheckForEqual();
            //EvenOrOdd();
            //PositiveOrNegative();
            CanYouVote();
        }

        //LukeWarm Section #1
        public static void OneThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //LukeWarm Section #2

        public static void PrintBy3 ()
        {
            for (int i = 0; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }


        //LukeWarm Section #3
        public static void CheckForEqual()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 ==num2)
                Console.WriteLine($"{num1} is equal to {num2}");
            else 
                Console.WriteLine($"{num1} is not equal to {num2}");

        }


        //LukeWarm Section #4
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
                Console.WriteLine($"{num1} is an even number.");
            else
                Console.WriteLine($"{num1} is an odd number.");

        }


        //LukeWarm Section #5        
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
                Console.WriteLine($"{num1} is a positive number.");
            else if (num1 < 0)
                Console.WriteLine($"{num1} is a negative number.");
            else
                Console.WriteLine($"Zero is a neutral number.");
        }

        //LukeWarm Section #6       
        public static void CanYouVote()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine($"You are {age} years old. Therefore you are old enough to vote.  Vote wisely, and DON'T SCREW IT UP.");
            else
                Console.WriteLine("You are not old enough to vote.");
        }

    }
}
