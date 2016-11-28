using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT = BrokerageLib;

namespace BrokerageLib.Tests {
	[TestClass]
	public class GettingAVariableCommission_Should {
		
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
			public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold() {
			// Arrange
			var unitsSold = -2;
			var unitPrice = 50.00M;
			decimal expectedCommission = (unitsSold * unitPrice) *
																		SUT.Constants.CommissionRate.Standard;
			var calculator = new SUT.CommissionCalculator();

			// Act
			decimal calculatedCommision = calculator.DetermineVariableRate(unitsSold, unitPrice);

			// Assert
			Assert.AreEqual(expectedCommission, calculatedCommision);
		}


	}
}
