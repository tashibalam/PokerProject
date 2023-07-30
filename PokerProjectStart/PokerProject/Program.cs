using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLibrary;

namespace PokerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Create an instance of your CardSet class, and name it myDeck.
            CardSet myDeck = new CardSet();


            // b. Build a loop that does a Console.WriteLine 52 times.
            // inside the loop, use this line to write out the 52 unique cards.
            // (use my use a foreach loop if you prefer)
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(myDeck.cardArray[i].CardRank + " of " + myDeck.cardArray[i].CardSuit);
            }
               

            // end of program

            Console.ReadLine();

    }
}
}
