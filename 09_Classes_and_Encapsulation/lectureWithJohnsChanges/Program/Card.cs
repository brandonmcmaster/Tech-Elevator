using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Card
    {
        public Card()
        {

        }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public string Suit { get; }
        public string Value { get; }

        public override string ToString()
        {
            return Suit + " " + Value;
        }
    }
}
