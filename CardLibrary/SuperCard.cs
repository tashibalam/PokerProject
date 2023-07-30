using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public enum Suit
    {
        Club = 1,
        Diamond,
        Heart,
        Spade
    }

    public enum Rank
    {
        Deuce = 2,
        Three = 3,
        Four =4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public abstract class SuperCard : IComparable<SuperCard>
    {
        public Rank CardRank { get; set; }

        public abstract Suit CardSuit { get; set; }
        public bool inplay { get; set; }

        public abstract void Display();

        public int CompareTo(SuperCard other)
        {
            if (other.CardSuit < CardSuit)
            {
                return 1;
            }
            else if (other.CardSuit == CardSuit)
            {
                if (other.CardRank < CardRank)
                {
                    return 1;
                }
                return -1;
                
            }
            else
            {
                return -1;
            }
        }
    }
}
