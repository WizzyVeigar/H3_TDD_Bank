using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using H3_TDD_Bank;
using Autofac.Extras.Moq;

namespace TDD_Bank_Tests
{
    public class ATMTests
    {
        private ATM atm = new ATM();

        [Fact]
        public void InsertCard_ValidCardInserted()
        {
            Card card = new MasterCard(2, "Michael", "50131051", new BankAccount());

            atm.InsertCard(card);

            Assert.True(atm.CurrentAccount != null);
        }

        [Fact]
        public void InsertCard_NullParam()
        {
            Assert.Throws<ArgumentNullException>(() => atm.InsertCard(null));
        }


        [Fact]
        public void Login_ValidLogin()
        {
            BankAccount bank = new BankAccount
            {
                pinCode = "5423"
            };
            string pinCode = "5423";

            atm.Login(bank, pinCode);

            Assert.True(atm.LoggedIn);
        }

        [Theory]
        [InlineData("1906", "5034")]
        [InlineData("1906", "50")]
        [InlineData("1906", "")]
        [InlineData("1906", "4910491491")]
        [InlineData("1906", "dada")]
        [InlineData("1906", "€234")]
        public void Login_InvalidLogin(string actualPinCode, string attemptedPinCode)
        {
            //Arrange
            BankAccount bank = new BankAccount
            {
                pinCode = actualPinCode
            };

            //Act & Assert
            Assert.Throws<ArgumentException>(() => atm.Login(bank, attemptedPinCode));
        }
    }
}
