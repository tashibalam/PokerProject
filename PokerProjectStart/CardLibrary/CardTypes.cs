using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardClub : SuperCard
    {
        private Suit _CardSuit = Suit.Club;
        public override Suit CardSuit {
            get { return _CardSuit; }
            set { _CardSuit = value; }
        }
        public CardClub(Rank rank)
        {
            CardRank = rank;
        }
    }
    class CardDiamond : SuperCard
    {
        private Suit _CardSuit = Suit.Diamond;
        public override Suit CardSuit
        {
            get { return _CardSuit; }
            set { _CardSuit = value; }
        }
        public CardDiamond(Rank rank)
        {
            CardRank = rank;
        }
    }
    class CardHeart : SuperCard
    {
        private Suit _CardSuit = Suit.Heart;
        public override Suit CardSuit
        {
            get { return _CardSuit; }
            set { _CardSuit = value; }
        }
        public CardHeart(Rank rank)
        {
            CardRank = rank;
        }
    }
    class CardSpade : SuperCard
    {
        private Suit _CardSuit = Suit.Spade;
        public override Suit CardSuit
        {
            get { return _CardSuit; }
            set { _CardSuit = value; }
        }
        public CardSpade(Rank rank)
        {
            CardRank = rank;
        }
    }
}
