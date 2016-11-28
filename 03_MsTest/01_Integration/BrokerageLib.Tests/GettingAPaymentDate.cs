﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = BrokerageLib;

namespace BrokerageLib.Tests {
[TestClass ]
public class GettingAPaymentDate_Should {
  [TestMethod ] 
  public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday() {
    // arrange
    var pd = new SUT.PaymentSystem.PaymentDate();

    DateTime sampleDate = DateTime.Parse("7/6/2011");

    // act
    var resultWhichShouldBe30DaysLater = pd.CalculateFuturePaymentDate(sampleDate);

    // assert

    Assert.AreEqual(sampleDate.AddDays(30), resultWhichShouldBe30DaysLater);
  }

    [TestMethod]
    public void ReturnMonday_WhenProposedDateFallsOnSunday() {
      // arrange
      var pd = new SUT.PaymentSystem.PaymentDate();

      DateTime sampleDate = DateTime.Parse("7/8/2011");

      // act
      var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

      // assert

      Assert.AreEqual(DayOfWeek.Monday, resultDateWhichShouldBeMonday.DayOfWeek);
    }

    [TestMethod]
    public void ReturnMonday_WhenProposedDateFallsOnSaturday() {
      // arrange
      var pd = new SUT.PaymentSystem.PaymentDate();

      DateTime sampleDate = DateTime.Parse("7/7/2011");

      // act
      var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

      // assert

      Assert.AreEqual(DayOfWeek.Monday, resultDateWhichShouldBeMonday.DayOfWeek);
    }
  }
}
