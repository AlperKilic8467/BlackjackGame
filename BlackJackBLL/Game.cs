//Alper Kilic
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlackJackBLL
{
    public class Game
    {

        public delegate void UpdatePlayersDelegate(string[] players);
        public event UpdatePlayersDelegate UpdatePlayers;

        public delegate void StandDelegate();
        public event StandDelegate StandEvent;

        public delegate void ShuffleDelegate();
        public event ShuffleDelegate ShuffleEvent;

        public List<Deck> decks = new List<Deck>();
        public List<Player> players = new List<Player>();
        public Player dealer = new Player()
        {
            PlayerID = 0,
            Name = "Dealer"
        };

        public void AddPlayers(Player player)
        {
            players.Add(player);;
        }

        protected virtual void OnPlayerStand(Player player)
        {
            if (StandEvent != null)
            {
                player.IsFinished = true;
                StandEvent();
            }
        }

        protected virtual void OnDeckShuffle()
        {
            if (StandEvent != null)
            {
                decks[0].Shuffle();
                ShuffleEvent();
            }
        }

        protected virtual void OnPlayersUpdate()
        {
            if (UpdatePlayers != null)
            {
                String[] PlayersArray = players.Select(o => Convert.ToString(o)).ToArray();
                UpdatePlayers(PlayersArray);
            }
        }

        public void AddDecks(Deck deck)
        {
            decks.Add(deck);
        }

        public void InitializeGame()
        {
            decks[0].Shuffle(); 
            dealer.Hand.AddCard(decks[0].DrawNext());
            dealer.Hand.AddCard(decks[0].DrawNext());

            for (int i = 0; i < players.Count; i++)
            {
                players[i].Hand.AddCard(decks[0].DrawNext());
                players[i].Hand.AddCard(decks[0].DrawNext());
            }

            OnPlayersUpdate();
        }

        public Card Deal()
        {
            return decks[0].DrawNext();
        }

        public void DealCard(int i)
        {
            players[i].Hand.AddCard(Deal());
            OnPlayersUpdate();
        }


        public void CheckifThick(Player player)
        {
            if(player.Hand.Score > 21)
            {
                player.IsThick = true;
            }
            else
            {
                player.IsThick = false;
            }
        }

        public void Cantplay()
        {
            OnPlayersUpdate();
        }

        public void Stand(Player player)
        {
            OnPlayerStand(player);
            //OnPlayersUpdate();
        }

        public void Shuffle()
        {
            OnDeckShuffle();
        }

        public bool GameFinished()
        {
            if (players.All(x => x.IsThick || x.IsFinished))
            {
                if (dealer.Hand.Score < 16)
                {
                    dealer.Hand.AddCard(decks[0].DrawNext());
                }
                System.Threading.Thread.Sleep(1000);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SelectWinner()
        {
            players.OrderByDescending(o => o.Hand.Score);
            
            if (players.Where(o => o.IsFinished == true).First().Hand.Score > dealer.Hand.Score || dealer.Hand.Score > 21) {
                var winner = players.Where(o => o.IsFinished == true).First().ToString();
                return "Winner is: " + winner;
            }
            else
            {
                return "Dealer won with score" + dealer.Hand.Score.ToString();
            }
        }

    }
}
