using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_TDD_Bank
{
    public class ATM
    {
        public BankAccount CurrentAccount { get; set; }

        MoneyProcessor moneyProcessor = new MoneyProcessor();

        public void Login(BankAccount bankAccount,string pinCode)
        {
        }
        

        public int WithDrawMoney(Account account, int withDrawAmount)
        {
            moneyProcessor.WithDrawMoney(account, withDrawAmount);
        }
    }
}
