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

        private List<string> Database()
        {
            var cardHolders = new List<string>() { "Farhan Nazir", "Seif Tabaja" };
            return cardHolders;
        }

        public void ValidateCard()
        {
            var testCard = new AppData(CardHolder, CardType, CardNumber, CardCSV, CardExpiryDate);
            var cardInfo = testCard.AllCardsInfo();
            Console.WriteLine("Total Cards" + cardInfo.Count);
            foreach (var card in cardInfo)
            {
                Console.WriteLine("Card Info: {0}", card);

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
    }
}
