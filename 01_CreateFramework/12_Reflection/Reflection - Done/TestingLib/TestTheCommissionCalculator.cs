using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLib {
	class TestTheCommissionCalculator {
		[CheckThisMethod]
		public void ReturnStandardCommission() {
			var unitsSold = 90;
			var unitPrice = 50.00M;
			var calculator = new BrokerageLib.CommissionCalculator();

			decimal expectedCommission = (unitsSold * unitPrice) *
																 BrokerageLib.Constants.CommissionRate.Standard;
			decimal calculatedCommission = calculator.DetermineVariableRate(unitsSold, unitPrice);


			Assert.AreEqual(expectedCommission, calculatedCommission, "Commission is not correct!");
		}
	}
}
