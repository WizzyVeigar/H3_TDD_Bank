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
    public class MoneyProcessorTests
    {
        MoneyProcessor moneyProcessor = new MoneyProcessor();

        [Fact]
        public void WithDrawMoney_ValidWithDrawal()
        {
            //arrange
            Account account = new Account { Balance = 500 };

            //Act & Assert
            Assert.True(moneyProcessor.WithDrawMoney(account, 250) > 0);
        }

        [Theory]
        [InlineData(50000)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void WithDrawMoney_InvalidWithDrawal(int moneyToWithDraw)
        {
            Account account = new Account { AccountName = "TestAccount", Balance = 1000 };

            Assert.Throws<ArgumentException>(() => moneyProcessor.WithDrawMoney(account, moneyToWithDraw));
        }
    }
}
