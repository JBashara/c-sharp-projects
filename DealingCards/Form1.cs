using DealingCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealingCards
{
    public partial class Form1 : Form
    {
        List<Card> deck;
        List<Card> hand;
        Random random = new Random();
        int nextCard;

        public Form1()
        {
            InitializeComponent();
            nextCard = random.Next(1, 52);

            deck = new List<Card>();
            for(int suit = 0; suit <= 3; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    deck.Add(new Card((Suits)suit, (Values)value));
                }
            }

            hand = new List<Card>();

            for(int i = 0; i < 52; i++)
            {
                DeckBox.Items.Add(deck[i].ToString());
            }
        }

        private void DrawCard_Click(object sender, EventArgs e)
        {
            nextCard = random.Next(0, deck.Count);
            if (deck.Count == 0 )
            {
                MessageBox.Show("Deck is Empty");
            }
            else
            {
                HandBox.Items.Clear();

                if (!hand.Contains(deck[nextCard]))
                {
                    hand.Add(deck[nextCard]);
                }

                for (int i = 0; i < hand.Count; i++)
                {
                    HandBox.Items.Add(hand[i].ToString());
                }

                DeckBox.Items.RemoveAt(nextCard);
                deck.RemoveAt(nextCard);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            hand.Sort();

            HandBox.Items.Clear();

            for (int i = 0; i < hand.Count; i++)
            {
                HandBox.Items.Add(hand[i].ToString());
            }
        }
    }
}
