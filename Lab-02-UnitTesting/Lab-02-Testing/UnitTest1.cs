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
      /*
        [Fact]
        public void CanWithdrawMoney()
        {
            Assert.Equal(200, Program.WithdrawMoney(1000));
        }

        [Fact]
        public void CanDepositMoney()
        {
            Assert.Equal(500, Program.DepositMoney(1000));
        }
        */
    }
}
