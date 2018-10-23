//Alper Kilic
using BlackJackBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackUI
{
    public partial class Formen : Form
    {
        public Game m;
        public Player player;
        int PlayerCounter = 0;

        public Formen()
        {
            InitializeComponent();
            m = new Game();
            m.UpdatePlayers += UpdatePlayers;
            m.StandEvent += Stand;
            m.ShuffleEvent += Shuffle;
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            ShuffleBtn.Enabled = false;
            
        }

        public void Stand()
        {
            MessageBox.Show("Player " + (PlayerCounter+1) + " Stood");
        }

        public void Shuffle()
        {
            MessageBox.Show("deck shuffled");
        }

        public void UpdatePlayers(string[] players)
        {
            foreach(var player in players)
            {
                tableLayoutPanel1.Controls.Add(new Label { Text = player, AutoSize = true });
            }
        }

        public void Update()
        {
            if(m.GameFinished() == true)
            {
                label1.Text = m.dealer.ToString();
                MessageBox.Show(m.SelectWinner());
            }
            if(m.players[PlayerCounter].IsThick == true)
            {
                PlayerCounter++;
            }

            if (PlayerCounter > m.players.Count - 1)
            {
                PlayerCounter = 0;
            }

            BigLabel.Text = "Player " + (PlayerCounter + 1) + "s turn";
        }
       
        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NbrOfDecksTB.Text) || string.IsNullOrWhiteSpace(NbrOfPlayersTB.Text))
            {
                MessageBox.Show("Please fill in the amount of players and decks!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Start a new game", "New Game",
                      MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    m.players.Clear();
                    tableLayoutPanel1.Controls.Clear();
                    m.dealer.Reset();
                    int NbrofPlayers;
                    int.TryParse(NbrOfPlayersTB.Text, out NbrofPlayers);

                    for (int i = 0; i < NbrofPlayers; i++)
                    {

                        m.AddPlayers(new Player() { PlayerID = i + 1, Name = "Player" });
                    }
                    int NbrofDecks;
                    int.TryParse(NbrOfDecksTB.Text, out NbrofDecks);

                    for (int i = 0; i < NbrofDecks; i++)
                    {
                        m.AddDecks(new Deck());
                    }
                    m.InitializeGame();
                    Update();


                    HitBtn.Enabled = true;
                    StandBtn.Enabled = true;
                    ShuffleBtn.Enabled = true;
                    label1.Text = m.dealer.ToString();
                }

            }
        
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                tableLayoutPanel1.Controls.Clear();
                foreach (var player in m.players)
                {
                    m.CheckifThick(player);
                }

                if (m.players[PlayerCounter].IsThick == false && m.players[PlayerCounter].IsFinished != true)
                {
                    
                    m.DealCard(PlayerCounter);
                    
                    //PlayerCounter++;
                    Update();
                }


                else if (m.players[PlayerCounter].IsThick == true)
                {
                    MessageBox.Show("Player " + (PlayerCounter+1) + " Is thick and cant draw a card");
                    m.Cantplay();
                   // PlayerCounter++;
                    Update();
                }
                else
                {
                    m.Cantplay();
                    MessageBox.Show("Player chose to stand and cant get a card");
                   // PlayerCounter++;
                    Update();
                }

               
                //Update();
                //PlayerCounter++;
               // UpdatePlayers();
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            //fixa event
            Shuffle();
        }

        private void StandBtn_Click(object sender, EventArgs e)
        {
            m.Stand(m.players[PlayerCounter]);
            PlayerCounter++;
            Update();
        }
    }
}
