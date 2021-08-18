using H3_TDD_Bank;
using System;

namespace H3_TDD_Bank
{
    public class MasterCard : Card
    {
        public DateTime ExpiryDate { get; private set; }
        public MasterCard(int cardId, string cardOwner, string cardNumber, BankAccount account) 
            : base(cardId, cardOwner, cardNumber, account)
        {
            ExpiryDate = DateTime.Now.AddYears(2);
        }
    }
}