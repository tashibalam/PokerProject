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

            int howManyCards = 5;
            int balance = 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Welcome to the game of Poker! You will start with ${0}. Each turn will cost you $1 to play.", balance);
            Console.WriteLine("Press Enter to play");
            Console.ReadLine();
            while (balance > 0)
            {
                SuperCard[] computerHand = myDeck.GetCards(howManyCards);
                SuperCard[] playersHand = myDeck.GetCards(howManyCards);
                Array.Sort(computerHand);
                Array.Sort(playersHand);
                DisplayHands(computerHand, playersHand);
                bool won = CompareHands(playersHand, computerHand);
                if (won && balance > 0)
                {
                    balance++;
                    Console.WriteLine("You Won! Press enter to play again.");
                    Console.WriteLine("Your new balance is ${0}", balance);
                    Console.ReadLine();
                }
                else if (!won && balance > 0)
                {
                    balance--;
                    Console.WriteLine("Sorry you lost. Press enter to play again.");
                    Console.WriteLine("Your new balance is ${0}", balance);
                    Console.ReadLine();
                }
                if (balance == 0)
                {
                    Console.WriteLine("Your out of money!");
                }

                myDeck.ResetUsage();
            }
            // end of program
            Console.ReadLine();

        }

        public static void DisplayHands(SuperCard[] array1, SuperCard[] array2)
        {
            Console.Clear();
            Console.WriteLine("This is the computers hand:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i].Display();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine("This is the Players hand:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i].Display();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        public static bool CompareHands(SuperCard[] array1, SuperCard[] array2)
        {
            int playerTotal = 0;
            int computerTotal = 0;
            bool won = false;
            for (int i = 0; i < array1.Length; i++)
            {
                playerTotal += (int)array1[i].CardRank;
            }
            for (int i = 0; i < array2.Length; i++)
            {
                computerTotal += (int)array2[i].CardRank;
            }
            if (playerTotal > computerTotal)
            {
                won = true;
            }

            return won;
        }
    }
}
