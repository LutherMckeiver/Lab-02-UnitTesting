using System;
using Xunit;
using Lab_02_UnitTesting;

namespace Lab_02_Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000)]
        [InlineData(5000)]
        [InlineData(0)]
        public void CanViewExpectedBalance(decimal userBalance)
        {
            Assert.Equal(userBalance, Program.ViewBalance(userBalance));
        }


        [Theory]
        [InlineData(500, "200", "You have 300 left in your account.")]
        [InlineData(500, "400", "You have 100 left in your account.")]
        [InlineData(500, "499", "You have 1 left in your account.")]
        public void CanWithdrawMoney(decimal userBalance, string userAmount, string expectation)
        {
            Assert.Equal(expectation, Program.WithdrawMoney(userBalance, userAmount));
        }

        [Theory]
        [InlineData(500, "1000", "Funds insuffiecient, you have 500 in your account.")]
        [InlineData(500, "3200", "Funds insuffiecient, you have 500 in your account.")]
        public void CantWithdrawMoreThanBalance(decimal userBalance, string userAmount, string expectation)
        {
            Assert.Equal(expectation, Program.WithdrawMoney(userBalance, userAmount));
        }


        [Theory]
        [InlineData(500, "1500", "2000")]
        [InlineData(200, "9800", "10000")]
        public void CanDepositMoney(decimal userBalance, string userInput, string expectation)
        {
            Assert.Equal(expectation, Program.DepositMoney(userBalance, userInput));
        }

        [Fact]
        public void DepositMoneyWrongFormatThrowsException()
        {
            Assert.Throws<FormatException>(() => Program.DepositMoney(500, "hey"));

        }

       
    }
}
