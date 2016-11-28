using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = BrokerageLib;

namespace BrokerageLib.Tests {
  [TestClass]
  public class AccessingAccount_Should {
    public const String CUSTOMER_NAME = "Mr. Heltman Azon";
    [TestMethod]
    public void UpdateBalanceCorrectly_DuringDebitAction() {
      // arrange
      decimal beginningBalance = 12.05M;
      decimal debitAmount = 2.02M;
      decimal expected = 10.03M;
      SUT.Account account = new SUT.Account(CUSTOMER_NAME, beginningBalance);

      // act
      account.Debit(debitAmount);

      // assert
      decimal actual = account.Balance;
      Assert.AreEqual(expected, actual, "Account not debited correctly");
    }
    [TestMethod]
    public void UpdateBalanceCorrectly_DuringCreditAction() {
      // arrange
      decimal beginningBalance = 5.06M;
      decimal depositAmount = 3.01M;
      decimal expected = 8.07M;
      SUT.Account account = new SUT.Account(CUSTOMER_NAME, beginningBalance);

      // act
      account.Credit(depositAmount);

      // assert
      decimal actual = account.Balance;
      Assert.AreEqual(expected, actual, "Account not debited correctly");
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void ThrowExceptionWhenOverdrawn_DuringDebitAction() {
      // arrange
      decimal beginningBalance = 12.05M;
      decimal debitAmount = 12.06M;

      SUT.Account account = new SUT.Account(CUSTOMER_NAME, beginningBalance);

      // act
      account.Debit(debitAmount);

     
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
       public void ThrowException_WhenNegativeDebitAmount() {
      // arrange
      decimal beginningBalance = 12.05M;
      decimal debitAmount = -5.0M;

      SUT.Account account = new SUT.Account(CUSTOMER_NAME, beginningBalance);

      // act
      account.Debit(debitAmount);


    }
  }
}
