using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardSet 
    {
        public SuperCard[] cardArray;
        Random rnd = new Random();

        public CardSet()
        {
            cardArray = new SuperCard[52];
            int position = 0;
            for (int i = 2; i < 15; i++)
            {
                cardArray[position++] = new CardClub((Rank)i);
                cardArray[position++] = new CardDiamond((Rank)i);
                cardArray[position++] = new CardHeart((Rank)i);
                cardArray[position++] = new CardSpade((Rank)i);
            }
        }
        public SuperCard[] GetCards(int number)
        {
            SuperCard[] temparray = new SuperCard[number];
            int temp;
            
            for (int i = 0; i < number; i++)
            {
                do
                {
                    temp = rnd.Next(0, 52); // Get a random number from 0 to 52.

                } while (cardArray[temp].inplay);
                temparray[i] = cardArray[temp];
                cardArray[temp].inplay = true;
            }

            return temparray;
        }
        public void ResetUsage()
        {
            for (int i = 0; i < cardArray.Length; i++)
            {
                cardArray[i].inplay = false;
            }
        }
    }
}

