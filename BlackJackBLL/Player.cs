using System;

namespace BlackJackBLL
{
    public class Player
    {
        //public delegate void Resetdelegate();
        //public event Resetdelegate Resetevent;

        public int PlayerID { get; set; }
        public Hand Hand { get; set; }
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public string Name { get; set; }

        public Player()
        {
            this.Hand = new Hand();
            this.Name = Name;
            this.PlayerID = PlayerID;
        }

        public void Reset()
        {
            Hand = new Hand();
            IsFinished = false;
            IsThick = false;
        }

        public override string ToString()
        {
            return Name + PlayerID + ": " + Hand;
        }
    }
}
