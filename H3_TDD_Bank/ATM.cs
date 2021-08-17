using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_TDD_Bank
{
    public class ATM
    {
        public BankAccount CurrentAccount { get; private set; }
        public bool LoggedIn { get; private set; }
        MoneyProcessor moneyProcessor = new MoneyProcessor();

        public void InsertCard(Card cardToInsert)
        {
            if (cardToInsert != null)
            {
                CurrentAccount = cardToInsert.AttachedBankAccount;
            }
            else
                throw new ArgumentNullException("You have to insert a card");
        }

        public void Login(BankAccount bankAccount, string pinCode)
        {
            if (bankAccount != null && !string.IsNullOrWhiteSpace(pinCode))
            {
                if (bankAccount.pinCode == pinCode)
                {
                    LoggedIn = true;
                }
                else
                    throw new ArgumentException("The pincode was wrong");
            }
            else
                throw new ArgumentException();
        }

        public string WithDrawMoney(Account account, int withDrawAmount)
        {
            if (account != null)
            {
                return "You withdrew: " + moneyProcessor.WithDrawMoney(account, withDrawAmount);
            }
            else
                return "You have not chosen a valid account";


        }
    }
}
