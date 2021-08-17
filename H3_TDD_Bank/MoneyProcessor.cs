using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_TDD_Bank
{
    public class MoneyProcessor
    {
        public int WithDrawMoney(Account account, int withDrawAmount)
        {
            if (withDrawAmount <= account.Balance && withDrawAmount > 0)
            {
                account.Balance -= withDrawAmount;
                return withDrawAmount;
            }
            else
                throw new ArgumentException("You can't withdraw more than you have on this account");
        }
    }
}
