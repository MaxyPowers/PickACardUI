using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            //Если это 1, то вернуть "Туз".
            if (value == 11) return "Jack";
            //Если это 11, то вернуть "Валет".
            if (value == 12) return "Queen";
            //Если это 12, то вернуть "Дама".
            if (value == 13) return "King";
            //Если это 13, то вернуть "Король".
            return value.ToString();
            //Вернуть значение переменной в строковом представлении.
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";
            //Если это 1, то вернуть "Спадес".
            if (value == 2) return "Hearts";
            //Если это 2, то вернуть "Сердечки".
            if (value == 3) return "Clubs";
            //Если это 3, то вернуть "Клубы".
            return "Diamonds";
            //Если выполнение продолжается, то вернуть "Диаманты".
        }

        
    }
}
