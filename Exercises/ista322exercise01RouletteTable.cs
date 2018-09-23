using System;

namespace ConsoleApp14
{
    class ista322exercise01RouletteTable
    {
        /*private static bool EnterKey()
        {
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
            {
            }
            return true;
        }*/

        static void Main(string[] args)
        {
            string[] wheel = new string[38] { "GREEN", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "BLACK", "RED", "GREEN", };

            Console.WriteLine("Welcome To Mike's Roulette Table");
            Console.WriteLine("Where The House Always Wins!");
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Test Your Luck");
            Console.ReadLine();


            //Console.WriteLine("\nThe Value of the Array is: [{0}]", string.Join(",", wheel[0]));

            for (int i = 0; i < wheel.Length-1; i++)
            {

                int num = i;
                string color = wheel[i];
                Console.WriteLine();
                Console.WriteLine("The Ball landed in slot: {0}", string.Join(" | ", wheel[num], num));
               

                bool even = num % 2 == 0;
                

                if ((even == true) && !(num is 0)) 
                {
                    Console.WriteLine("Even/Odd: EVEN");

                }
                else if (num is 0)
                {
                    Console.WriteLine("Even/Odd: LOSER");
                }
                else
                {
                    Console.WriteLine("Even/Odds: ODD");
                }

                if (color == "GREEN")
                {
                    Console.WriteLine("Red/Black: LOSER");
                }
                else if (color == "BLACK")
                {
                    Console.WriteLine("Red/Black: BLACK");
                }
                else
                {
                    Console.WriteLine("Red/Black: RED");
                }

                if ((num >= 1) && (num <= 18))
                {
                    Console.WriteLine("Lows/Highs: LOW");
                }
                else if ((num >= 19) && (num <= 36))
                {
                    Console.WriteLine("Lows/Highs: HIGH");
                }
                else
                {
                    Console.WriteLine("Lows/Highs: LOSER");
                }

                if ((num > 0) && (num < 13))
                {
                    Console.WriteLine("Dozens: 1st 12");
                }
                else if ((num > 12) && (num < 25))
                {
                    Console.WriteLine("Dozens: 2nd 12");
                }
                else if ((num > 24) && (num < 39))
                {
                    Console.WriteLine("Dozens: 3rd 12");
                }
                else
                {
                    Console.WriteLine("Dozens: LOSER");
                }

                if ((num % 3 == 0) && !(num is 0))
                {
                    Console.WriteLine("Column: 3");
                    Console.WriteLine("Street Winners Are: {0}", string.Join(", ", num - 2, num - 1, num));

                    if ((num > 3) && (num < 36))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 2, num - 1, num, num + 1, num + 2, num + 3), "|", (num - 5, num - 4, num - 3, num - 2, num - 1, num)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num - 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num - 3, num - 4, num - 1, num), (num, num - 1, num + 2, num + 3)));
                    }
                    else if ((num == 3))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 2, num - 1, num, num + 1, num + 2, num + 3)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num - 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join("  ", (num, num - 1, num + 2, num + 3)));
                    }
                    else
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 5, num - 4, num - 3, num - 2, num - 1, num)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num - 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join("  ", (num - 3, num - 4, num - 1, num)));
                    }
                   
                }
                else if ((num % 3 == 2) && !(num is 0))
                {
                    Console.WriteLine("Column: 2");
                    Console.WriteLine("Street Winners Are: {0}", string.Join(", ", num + 1, num, num -1));

                    if ((num > 2) && (num < 35))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 1, num, num + 1, num + 2, num + 3, num + 4), "|", (num - 4, num - 3, num - 2, num - 1, num, num + 1)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", (num, num + 1), (num, num - 1)));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num - 3, num - 4, num - 1, num), (num, num - 1, num + 2, num + 3), (num -2, num - 3, num, num + 1), (num + 1, num, num + 3, num + 4)));
                    }
                    else if ((num == 2))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 1, num, num + 1, num + 2, num + 3, num + 4)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", (num, num + 1), (num, num - 1)));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ",(num, num - 1, num + 2, num + 3),(num + 1, num, num + 3, num + 4)));
                    }
                    else
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 4, num - 3, num - 2, num - 1, num, num + 1)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", (num, num + 1), (num, num - 1)));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num - 3, num - 4, num - 1, num), (num - 2, num - 3, num, num + 1)));
                    }
                }
                else if ((num % 3 == 1) && !(num is 0))
                {
                    Console.WriteLine("Column: 1");
                    Console.WriteLine("Street Winners Are: {0}", string.Join(", ", num, num + 1, num + 2));

                    if ((num > 1) && (num < 34))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num, num + 1, num + 2, num + 3, num + 4, num + 5), "|", (num - 3, num - 2, num - 1, num, num + 1, num + 2)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num + 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num - 3, num - 2, num + 1, num), (num, num + 1, num + 4, num + 3)));
                    }
                    else if ((num == 1))
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num, num + 1, num + 2, num + 3, num + 4, num + 5)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num + 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num, num + 1, num + 4, num + 3)));
                    }
                    else
                    {
                        Console.WriteLine("6 Number Winners are: {0}", string.Join(" ", (num - 3, num - 2, num - 1, num, num + 1, num + 2)));
                        Console.WriteLine("Split: {0}", string.Join(" | ", num, num + 1));
                        Console.WriteLine("Corner Winners: {0}", string.Join(" | ", (num - 3, num - 2, num + 1, num)));
                    }
                   
                }
                else
                {
                    Console.WriteLine("Column: LOSER");
                    Console.WriteLine("Street Winners Are: NONE");
                    Console.WriteLine("6 Number Winners are: NONE");
                    Console.WriteLine("Split: NONE");
                    Console.WriteLine("Corner Winners: NONE");
                }


                

                

                



            }


        }
    }
}
