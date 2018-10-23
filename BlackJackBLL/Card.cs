using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackBLL
{
    public class Card
    {

        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Value { get; set; }

        public Card()
        {

        }

        public override string ToString()
        {
            return Face + " " + "of " + Suit + " ";
        }
    }
}
