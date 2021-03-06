using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_TDD_Bank
{
    public abstract class Card
    {       
        public int CardId { get; protected set; }
        public string CardOwner { get; protected set; }
        public string CardNumber { get; protected set; }
        public BankAccount AttachedBankAccount { get; set; }
        protected Card(int cardId, string cardOwner, string cardNumber, BankAccount account)
        {
            CardId = cardId;
            CardOwner = cardOwner;
            CardNumber = cardNumber;
            AttachedBankAccount = account;
        }

    }
}
