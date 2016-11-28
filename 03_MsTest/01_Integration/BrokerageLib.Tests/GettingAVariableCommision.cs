using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SUT = BrokerageLib;

namespace BrokerageLib.Tests {

  [TestClass]
  public class GettingAVariableCommisionRate_Should {

    [TestMethod]
   
    public void ReturnStandardCommission_WhenAmountsAreBelowThresholds() {
      // Arrange

      var unitsSold = 90;
      var unitPrice = 50.00M;
      var calculator = new SUT.CommissionCalculator();

      // Act
      decimal calculatedCommision = calculator.DetermineVariableRate(unitsSold, unitPrice);

      // Assert
      decimal expectedCommission = (unitsSold * unitPrice) *
                                   SUT.Constants.CommissionRate.Standard;
      Assert.AreEqual(expectedCommission, calculatedCommision);
    }

    [TestMethod]
   
    public void ReturnTopCommission_WhenUnitAmountOverThreshold() {
      // Arrange

      var unitsSold = 401;
      var unitPrice = 50.00M;
      var calculator = new SUT.CommissionCalculator();

      // Act
      decimal calculatedCommision = calculator.DetermineVariableRate(unitsSold, unitPrice);

      // Assert
      decimal expectedCommission = (unitsSold * unitPrice) *
                                   SUT.Constants.CommissionRate.Top;
      Assert.AreEqual(expectedCommission, calculatedCommision);
    }

    [TestMethod]

   
    public void ReturnTopCommission_WhenGrossSaleAmountOverThreshold() {
      // Arrange

      var unitsSold = 101;
      var unitPrice = 120.00M;
      var calculator = new SUT.CommissionCalculator();

      // Act
      decimal calculatedCommision = calculator.DetermineVariableRate(unitsSold, unitPrice);

      // Assert
      decimal expectedCommission = (unitsSold * unitPrice) *
                                   SUT.Constants.CommissionRate.Top;
      Assert.AreEqual(expectedCommission, calculatedCommision);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    
    public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold() {
      // Arrange

      var unitsSold = -1;
      var unitPrice = 120.00M;
      var calculator = new SUT.CommissionCalculator();

      // Act
      decimal calculatedCommision = calculator.DetermineVariableRate(unitsSold, unitPrice);

      // Assert
      decimal expectedCommission = (unitsSold * unitPrice) *
                                    SUT.Constants.CommissionRate.Top;
      Assert.AreEqual(expectedCommission, calculatedCommision);
    }
  }
}