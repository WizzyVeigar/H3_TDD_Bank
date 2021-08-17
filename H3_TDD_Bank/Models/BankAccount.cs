using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_TDD_Bank
{
    public class BankAccount
    {
        public Person Owner { get; set; }
        public List<Account> Accounts { get; set; }
        public string pinCode { get; set; }
    }
}
