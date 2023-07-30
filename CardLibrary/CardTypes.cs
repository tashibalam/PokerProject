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
        public override void Display()
        {
            // Code to Display a club card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♣");
            Console.ResetColor();
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
        public override void Display()
        {
            // Code to Display a diamond card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♦");
            Console.ResetColor();
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
        public override void Display()
        {
            // Code to Display a heart card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♥");
            Console.ResetColor();
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
        public override void Display()
        {
            // Code to Display a heart card...
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(CardRank + " of " + _CardSuit + "s ♠");
            Console.ResetColor();
        }
    }
}
