using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT = BrokerageLib;

namespace TestingLib {
	public class TestThePaymentDate {

		public UnitTestInfo DateIs30DaysInFuture() {

			var testInfo = new UnitTestInfo();
			var pd = new SUT.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/6/2011");

			var futureDate = pd.CalculateFuturePaymentDate(sampleDate);

			if (futureDate.Equals(sampleDate.AddDays(30)))
			{
				testInfo.DidTestPass = true;
			}
			else {
				testInfo.DidTestPass = false;
				testInfo.TestFailureMessage = "Expected date is not 30 days in the future.";
			}
			return testInfo;
		}
	}
	public struct UnitTestInfo {
		public bool DidTestPass { get; set; }
		public string TestFailureMessage { get; set; }

	}
}
