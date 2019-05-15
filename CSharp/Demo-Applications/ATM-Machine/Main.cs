using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Demo_Applications.ATM_Machine
{
    class Main
    {
        public void Start()
        {

            var headerBuilder = new StringBuilder();
            var title = "Welcome to IT-Spider ATM-System";
            headerBuilder
                .Append('-', title.Length)
                .AppendLine()
                .Append(title)
                .AppendLine()
                .Append('-', title.Length);


            
            Console.WriteLine(headerBuilder + "\n");
            var cardValidation = new CardAuthenication("Farhan Nazir", "Visa", 855522211, 685, DateTime.Now);
            var cardValidation1 = new CardAuthenication("Seif Tabaja", "Master", 12252582, 789, DateTime.Now);
            cardValidation.ValidateCard();
            cardValidation1.ValidateCard();



        }
    }
}
