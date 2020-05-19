using System;

namespace Control_Flow_Exercises_2
{
    public class Exercises
    {
        // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        // Display the count on the console.
        public static void Exercise1()
        {
            var counter = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) counter++;
            }
            

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", counter);
        }

        // 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.
        public static void Exercise2()
        {
            var counter = 0;

            while (true)
            {
                Console.Write("Enter a number, or 'ok' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok") break;

                counter += int.Parse(input);

            }

            Console.WriteLine("Sum of all numbers is: " + counter);
        }

        // 3- Write a program and ask the user to enter a number.
        // Compute the factorial of the number and print it on the console.
        // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as '5! = 120'.
        public static void Exercise3()
        {
            Console.Write("Enter a number to factorialize: ");

            var input = Convert.ToInt64(Console.ReadLine());
            long result = 1;

            for (var i = 1; i <= input; i++)
            {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}", input, result);
        }

        // 4- Write a program that picks a random number between 1 and 10.
        // Give the user 4 chances to guess the number.
        // If the user guesses the number, display “You won"; otherwise, display “You lost".
        // (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void Exercise4()
        {
            var secret = new Random().Next(1, 10);
            Console.WriteLine("Computer has chosen a random number from 1 to 10");
            Console.WriteLine("//secret number is {0}//", secret);

            for (var i = 4; i > 0; i--)
            {
                Console.Write("Guess the number ({0} guesses remaining): ", i);

                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("You won");
                    break;
                }

                if (i == 1)
                {
                    Console.WriteLine("You lost");
                }
            }
        }

        // 5- Write a program and ask the user to enter a series of numbers separated by comma.
        // Find the maximum of the numbers and display it on the console.
        // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        public static void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma, eg '4, 6, 1, 2, 12':");
            var input = Console.ReadLine();


            // Regex to separate by comma and any number of whitespace including zero.
            const string split = @",\s*";
            var arr = System.Text.RegularExpressions.Regex.Split(input, split);

            // Set first number as max
            var max = Convert.ToInt64(arr[0]);

            foreach (var str in arr)
            {
                var num = Convert.ToInt64(str);
                if (num > max) max = num;
            }

            Console.WriteLine("Maximum in list is: " + max);
        }
    }
}