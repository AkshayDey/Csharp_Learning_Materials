using BuilderPattern.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class GiftCardBuilder
    {
        public GiftCard _giftCard;

        public GiftCardBuilder()
        {
            _giftCard = new GiftCard();
        }

        public void AddColor(Color color)
        {
            if (color == Color.White)
            {
                Console.WriteLine("Color is White");
            }
            if (color == Color.Black)
            {
                Console.WriteLine("Color is Black");
            }
        }

        public void Something()
        {
           
        }

        public void SomethingOne()
        {

        }

        public GiftCard GetAllGiftCardItems()
        {
            return _giftCard;
        }
    }
}
