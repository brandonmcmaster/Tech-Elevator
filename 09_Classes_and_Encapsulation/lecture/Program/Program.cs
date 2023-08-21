using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card myCard = new Card("Heart", "7");

            Console.WriteLine(myCard);

            Deck deck = new Deck();
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(deck.DealACard());
            }
        }
    }
}
