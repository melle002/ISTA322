using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NumberGuess
{
    public class Program
    {
        static void Main()
        {

            var builder = new StringBuilder();
            builder.Append('-', 17);


            Console.WriteLine(builder);
            Console.WriteLine("THE GUESSING GAME");
            Console.WriteLine(builder);
            Console.WriteLine();

            Console.WriteLine("The Computer Has Picked a Number From 1-1000.\n" +
                              "Can You Guess what it is?");



            IEnumerable<int> numberList = Enumerable.Range(1, 1000).ToList();// re-look Lists and rewrite
            var input = Convert.ToInt32(Console.ReadLine());
            var ran = new Random(DateTime.Now.Millisecond);
            var ranNumber = numberList.ElementAt(ran.Next(0, numberList.Max()));



            //-------------------------------------------------------------Work Section for Computer to Guess---------------------------------------------------

            //Console.WriteLine("Pick a number from 1-1000");

            /*var numGuesses = 1;
                do
                {
                    numGuesses++;
                    var guess = numberList.Max() / 2;

                    if (guess < input)
                    {
                        Console.WriteLine("Computer guesses: {0} which is to low", guess);
                        continue;

                    }
                    else if (guess > input)
                    {
                        Console.WriteLine("Computer guesses: {0} which is to high", guess);
                        continue;
                    }
                    else
                        Console.WriteLine("Computer has guessed your number: {0}", input);


                } while (numGuesses < 11);*/

 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
 //                          Need to clean up code | Create Methods and strip unnecessary noise from Main Program Class
 //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

            l1:
            try
            {
                for (var i = 1; i < 11; i++)
                {
                    var numberGuess = Convert.ToInt32(Console.ReadLine());

                    if (numberGuess > ranNumber)
                    {
                        Console.WriteLine("Your number is too high! Try Again");
                        Console.WriteLine("Attempt: {0} of 10", i);

                    }
                    else if (numberGuess < ranNumber)
                    {
                        Console.WriteLine("Your number is too low!");
                        Console.WriteLine("Attempt: {0} of 10", i);
                    }
                    else
                    {
                        Console.WriteLine("Winner, Winner!");
                        break;

                    }
                }
                Console.WriteLine("Game Over. The number was: {0}", ranNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Try Again. Enter a number between 1-1000", ex.Message);
                goto l1;

            }

        }





    }

}
