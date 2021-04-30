using System;
using System.Collections.Generic;

namespace A_Deck_Of_Cards
{
    class Program
    {
        static void Main()
        {
            bool valid_input = false;
            bool valid_input2 = false;
            bool valid_input3 = false;

            while (valid_input != true)
            {
                //Starts the application with the choice of ending it.
                int choice = 0;
                Console.WriteLine($"Do you want to create a deck of cards?\n" +
                    $"Yes [1]\n" +
                    $"End [2]\n");

                //Checks and catches any input that isn't [1] or [2]
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch{}

                if (choice == 1)
                {
                    while (valid_input2 != true)
                    {
                        List<Card> Dealt = new List<Card>();
                        Deck Test = new Deck();
                        Console.WriteLine($"Do you Want to Shuffle the deck?\n" +
                            $"Yes [1]\n" +
                            $"No  [2]\n");

                        try
                        {
                            choice = Int32.Parse(Console.ReadLine());
                        }
                        catch{}
                        
                        if (choice == 1)
                        {
                            Test.Shuffle();
                            Test.console_print();
                            valid_input2 = true;
                        }

                        else if (choice == 2)
                        {
                            Console.WriteLine($"\nOKay\n");
                            valid_input2 = true;
                        }

                        else
                        {
                            Console.WriteLine($"\nYour input was invalid\n" +
                                $"Please input a Valid integer\n");
                        }
                            

                        while (valid_input3 != true)
                        {
                            Console.WriteLine($"Do you want to be dealt a card?\n" +
                            $"Yes        [1]\n" +
                            $"No         [2]\n" +
                            $"Check Deck [3]\n");

                            try
                            {
                                choice = Int32.Parse(Console.ReadLine());
                            }
                            catch {}

                            if (choice == 1)
                            {
                                Card hold = Test.Deal();
                                Dealt.Add(hold);
                                foreach (Card i in Dealt)
                                {
                                    Console.WriteLine($"\n{ i.Value }{ i.Suit }");
                                }
                            }

                            else if (choice == 2)
                            {
                                Console.WriteLine($"\nOKay\n");
                                Environment.Exit(0);
                            }

                            else if (choice == 3)
                            {
                                Test.isEmpty();
                            }

                            else
                            {
                                Console.WriteLine($"\nYour input was invalid\n" +
                                    $"Please input a Valid integer\n");
                            }
                        }

                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine($"\nOKay");
                    Environment.Exit(0);
                }

                else 
                {
                    Console.WriteLine($"\nYour input was invalid\n" +
                                $"Please input a Valid integer\n");
                }
            }

        }
    }

}
