using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackBLL
{
    public class Deck
    {

        public int Count { get; set; }

        public List<Card> cards;

        public Deck()
        {
            this.InitializeDeck();
            this.FillDeck();
        }
        public void InitializeDeck()
        {
            cards = new List<Card>();
        }
        public void DiscardCards()
        {
            cards.Clear();
        }

        public void FillDeck()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j, Value = Math.Min(j + 1, 10) });
                }
            }
        }

        public Card DrawNext()
        {
            if(cards.Count <= 0)
            {
                FillDeck();
            }
            Card DrawedCard = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return DrawedCard;
        }
      
        public void Shuffle()
        {
            Random rand = new Random();
            int c = cards.Count;

            while (c > 1)
            {
                c--;
                int r = rand.Next(c + 1);
                Card card = cards[r];
                cards[r] = cards[c];
                cards[c] = card;
            }
        }
    }
}
