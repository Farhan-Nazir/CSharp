using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Demo_Applications.ATM_Machine
{
    class CardAuthenication
    {
        public string CardHolder;
        public string CardType;
        public int CardNumber;
        public int CardCSV;
        public DateTime CardExpiryDate;
        private int CardPin;
        
     

        public CardAuthenication(string cardHolder, string cardType, int cardNumber, int cardCsv, DateTime cardExpiryDate)
        {
            CardHolder = cardHolder;
            CardCSV = cardCsv;
            CardNumber = cardNumber;
            CardType = cardType;
            CardExpiryDate = cardExpiryDate;
        }

        public void ValidateCard()
        {
            Console.WriteLine("Please enter your Pin: ");
            var cardPin = Convert.ToInt32(Console.ReadLine());
            var incominCard = new AppData(CardHolder, CardType, CardNumber, CardCSV, CardExpiryDate, cardPin);
            var cardInfo = incominCard.AllCardsInfo();
           // Console.WriteLine(cardInfo);
            foreach (var item in cardInfo)
            {
                Console.WriteLine(item);
            }
          
            //foreach (var cardHolderName in Database())
            //{
            //    Console.WriteLine("Please enter your Pin: ");
            //    var cardPin = Convert.ToInt32(Console.ReadLine());
            //    CardPin = cardPin;
            //    if (CardHolder == cardHolderName)
            //    {
                    
            //        Console.WriteLine("Welcome {0}", CardHolder);
            //        break;
            //    } else
            //    {
            //        Console.WriteLine("Card is not acceptable !!!");
            //    }
            //}

        }
        private string GetValueOfObject(object obj,string propertyName)
        {
            return Convert.ToString(obj.GetType().GetProperty(propertyName).GetValue(obj, null));
        }
    }
}
