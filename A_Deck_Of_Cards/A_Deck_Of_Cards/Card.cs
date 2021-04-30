using System;
using System.Collections.Generic;
using System.Text;

namespace A_Deck_Of_Cards
{
    class Card
    {
        public string Suit;
        public int Value; 
        public Card(string suit1, int value1)
        {
            Suit = suit1;
            Value = value1;
        }
    }
    
}
