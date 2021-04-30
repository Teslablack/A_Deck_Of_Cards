using System;
using System.Collections.Generic;
using System.Text;

namespace A_Deck_Of_Cards
{
    class Deck
    {
        //Creates a variable whose only function is to store objects, for movement between lists
        Card hold;

        //Creates the Deck of cards
        List<Card> Test_Deck = new List<Card>();
        public Deck()
        {
            for (int i = 1; i <= 13; i++)
            {
                Test_Deck.Add(new Card("Clubs", i));

                Test_Deck.Add(new Card("Diamnods", i));

                Test_Deck.Add(new Card("Hearts", i));

                Test_Deck.Add(new Card("Spades", i));
            }
        }

        //Checks how many Cards are left in the Deck
        public void isEmpty()
        {
            int Deck_Check = Test_Deck.Count;
            if (Deck_Check == 0)
            {
                Console.WriteLine($"The Deck is empty");
            }

            else
            {
                Console.WriteLine($"\nThere are {Deck_Check} Cards left in the Deck\n");
            }
        }

        //Riffle Shuffle
        public void Shuffle()
        {
            List<Card> Split1 = new List<Card>();
            List<Card> Split2 = new List<Card>();

            //Takes out half the cards in the Deck
            for (int i = 1; i <= 26; i++)
            {
                hold = Test_Deck[0];
                Split1.Add(hold);
                Test_Deck.RemoveAt(0);
            }

            //Takes out the other half of the cards in the Deck
            for (int i = 1; i <= 26; i++)
            {
                hold = Test_Deck[0];
                Split2.Add(hold);
                Test_Deck.RemoveAt(0);
            }

            //Adds the card back in one by one from each half
            for (int i = 1; i <= 26; i++)
            {
                hold = Split1[0];
                Test_Deck.Add(hold);
                Split1.RemoveAt(0);

                hold = Split2[0];
                Test_Deck.Add(hold);
                Split2.RemoveAt(0);
            }
        }

        //Deals 1 Card from the Deck
        public Card Deal()
        {
                hold = Test_Deck[0];
                Test_Deck.RemoveAt(0);
                return hold;
        }

        public void console_print()
        {
            foreach(Card i in Test_Deck)
            {
                Console.WriteLine($"{ i.Value }{ i.Suit }\n");
            }
        }
    }


}

