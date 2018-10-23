using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackBLL
{
    public class Hand
    {
        public List<Card> cardsinhand = new List<Card>();

        public Card LastCard { get; set; }
        public int NbrOfCards { get; set; }
        public int Score { get; set; }

        public void AddCard(Card card)
        {
            cardsinhand.Add(card);
            LastCard = card;
            Score += card.Value;
        }
        public void Clear()
        {
            cardsinhand.Clear();
        }
        public Hand()
        {
            this.LastCard = LastCard;
            this.NbrOfCards = cardsinhand.Count;
            this.Score = Score;
            
        }

        public override string ToString()
        {
            
            return "Score: " + Score + "\n " + String.Concat(cardsinhand.Select(o => { return o.ToString(); })) + " ";
        }
    }
}
