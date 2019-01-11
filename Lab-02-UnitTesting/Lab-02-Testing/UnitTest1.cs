using System;
using Xunit;
using Lab_02_UnitTesting;

namespace Lab_02_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void CanViewExpectedBalance()
        {
            Assert.Equal(1000, Program.ViewBalance(1000));
        }

       
        [Theory]
        [InlineData(500, "200", "You have 300 left in your account.")]
        public void CanWithdrawMoney(decimal userBalance, string userAmount, string expectation)
        {
            Assert.Equal(expectation, Program.WithdrawMoney(userBalance, userAmount));
        }

        [Theory]
        [InlineData(500, "1000", "Funds insuffiecient, you have 500 in your account.")]
        public void CantWithdrawMoreThanBalance(decimal userBalance, string userAmount, string expectation)
        {
            Assert.Equal(expectation, Program.WithdrawMoney(userBalance, userAmount));
        }

        [Theory]
        [InlineData(1000, "1000", "1000.00" )]
        public void CantWithdrawEqualToBalance(decimal userBalance, string userAmount, string expectation)
        {
            Assert.Equal(expectation, Program.WithdrawMoney(userBalance, userAmount));
        }
        
        [Theory]
        [InlineData(500, "1500", "2000")]
        public void CanDepositMoney(decimal userBalance, string userInput, string expectation)
        {
            Assert.Equal(expectation, Program.DepositMoney(userBalance, userInput));
        }
    }
}
