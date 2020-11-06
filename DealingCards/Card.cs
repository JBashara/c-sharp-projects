using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingCard
{
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    class Card : IComparable<Card>
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();
        }

        public int CompareTo(Card card)
        {
            if (this.Value > card.Value) return 1;
            else if (this.Value == card.Value) return 1;
            else return -1;
        }
    }
}
