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

    }
}

