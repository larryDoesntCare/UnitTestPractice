namespace TestingLib {

	internal class GettingAVariableCommisionRate_Should {

		[CheckThisMethod]
		public void ReturnStandardCommission_WhenSaleAmountsAreBelowThresholds() {
			var unitsSold = 90;
			var unitPrice = 50.00M;
			var calculator = new BrokerageLib.CommissionCalculator();

			decimal calculatedCommission = calculator.DetermineVariableRate(unitsSold, unitPrice);

			decimal expectedCommission = (unitsSold * unitPrice) *
																	 BrokerageLib.Constants.CommissionRate.Standard;
			Assert.AreEqual(expectedCommission, calculatedCommission, "Commission is not correct!");
		}
	}
}