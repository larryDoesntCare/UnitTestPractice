using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLib {
	class TestTheCommissionCalculator {

		[CheckThisMethod]
		public void Should_ReturnStandardCommission_GivenAmountsBelowThresholds() {
			// Arrange

			var unitsSold = 90;
			var unitPrice = 50.00M;
			var calculator = new BrokerageLib.CommissionCalculator();

			// Act
			decimal calculatedCommission = calculator.DetermineVariableRate(unitsSold, unitPrice);

			// Assert
			decimal expectedCommission = (unitsSold * unitPrice) *
																	 BrokerageLib.Constants.CommissionRate.Standard;
			Assert.AreEqual(expectedCommission, calculatedCommission, "Commission is not correct!");
		}
	}
}
