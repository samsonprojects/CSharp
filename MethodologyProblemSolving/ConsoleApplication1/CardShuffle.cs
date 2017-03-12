using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CardShuffle
    {
        static void Main()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "4", Suit = Suit.SPADE });
            cards.Add(new Card() { Face = "A", Suit = Suit.SPADE });
            cards.Add(new Card() { Face = "J", Suit = Suit.DIAMOND });
            cards.Add(new Card() { Face = "10", Suit = Suit.CLUB });

            Console.Write("Initial deck: ");
            PrintCards(cards);

            ShuffleCards(cards);
            Console.Write("After shuffle: ");
           


            PerformSingleSwap(cards);

            PrintCards(cards);
            Console.ReadLine();
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.Write(card);

            }
            Console.WriteLine();
        }

        static Random rand = new Random();

        static void PerformSingleSwap(List<Card> cards)
        {
            //TODO: Implement the method body
            
            int randomIndex = rand.Next(1, cards.Count);
            Card firstCard = cards[0];
            Card randomCard = cards[randomIndex];
            cards[0] = randomCard;
            cards[randomIndex] = firstCard;
        }

        static void ShuffleCards(List<Card> cards)
        {
            for(int i=1; i <= cards.Count; i++)
            {
                PerformSingleSwap(cards);
                PrintCards(cards);

            }
        }

        static void TestShuffle52Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };

            foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card() { Face = face, Suit = suit };
                    cards.Add(card);
                }
            }

            ShuffleCards(cards);
            PrintCards(cards);

        }
       

    }
}
