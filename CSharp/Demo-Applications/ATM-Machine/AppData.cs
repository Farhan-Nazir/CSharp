using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Demo_Applications.ATM_Machine
{

    class AppData
    {
        private string CardHolder;
        private string CardType;
        public int CardNumber;
        public int CardCSV;
        public DateTime CardExpiryDate;
        private int CardPin;
        public List<object> AllCards;
        

        public AppData (string cardHolder, string cardType, int cardNumber, int cardCsv, DateTime cardExpiryDate, int cardPin)
        {
            CardHolder = cardHolder;
            CardType = cardType;
            CardCSV = cardCsv;
            CardNumber = cardNumber;       
            CardExpiryDate = cardExpiryDate;
            CardPin = cardPin;
        }


        private Object NewCard()
        {
            var newcard = new
            {
                cardHolder = CardHolder,
                cardType = CardType,
                cardCsv = CardCSV,
                cardNumber = CardNumber,
                cardExpiryDate = CardExpiryDate,
                cardPin = CardPin
            };
            return newcard;
        }

        public List<object> AllCardsInfo()
        {
            AllCards = new List<object>();
           AllCards.Add(NewCard());
           
            return AllCards;
        }
    }
}
