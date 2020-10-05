using System;

/// Week 5		Lab 1
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  October 4th 2020

namespace Lecture_5_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            //create random number
            Random generator = new Random();
            int randNumber = generator.Next(1, 101);

            //counters
            int guess;
            int guesses = 0;
            bool correct = false;

            //loop guesses
            Console.WriteLine("Guess a number between 1 and 100");
            do
            {
                //take input
                guess = Int32.Parse(Console.ReadLine());

                //increment guesses
                guesses++;

                //check if correct
                if (guess < 1 || guess > 100)
                {

                    Console.WriteLine("Invalid guess, outside of specified range.");
                    guesses--;

                } else if (guess > randNumber)
                {

                    Console.WriteLine("Lower");

                } else if (guess < randNumber)
                {

                    Console.WriteLine("Higher");

                } else
                {

                    Console.WriteLine("You got it!");
                    Console.WriteLine("It took you {0} guesses!", guesses);
                    correct = true;

                }

;
            } while (!correct);

        }
    }
}
