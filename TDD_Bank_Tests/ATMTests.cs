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
        private ATM atm;

        [Fact]
        public void Login_ValidLogin()
        {
            BankAccount bank = new BankAccount
            {
                pinCode = "5423"
            };
            string pinCode = "5423";
            atm = new ATM();

            atm.Login(bank, pinCode);

            Assert.True(atm.CurrentAccount == bank);

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
