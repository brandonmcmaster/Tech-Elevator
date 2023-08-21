using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            cards.Add(new Card("Spades", "A"));
            cards.Add(new Card("Spades", "K"));
            cards.Add(new Card("Spades", "Q"));
        }

        public Card DealACard()
        {
            if (cards.Count > 0)
            {
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            else
            {
                return null;
            }
        }
    }
}
