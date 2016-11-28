using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT = BrokerageLib;

namespace TestingLib {
	
	public class TestThePaymentDate {
		[CheckThisMethod]
		public void DateIs30DaysInFuture() {

		
			var pd = new SUT.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/6/2011");

			var futureDate = pd.CalculateFuturePaymentDate(sampleDate);
			Assert.AreEqual(futureDate , sampleDate.AddDays(30), "Expected date is not 30 days in the future.");
			
		}
		[CheckThisMethod]
		public void ReturnsMondayIfProposedDateIsSunday() {

			var pd = new SUT.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/8/2011");

			var futureDate = pd.CalculateFuturePaymentDate(sampleDate);
			Assert.AreEqual(futureDate.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");
			
			
		}
		[CheckThisMethod]
		public void ReturnsMondayIfProposedDateIsSaturday() {

	
			var pd = new SUT.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/7/2011");

			var futureDate = pd.CalculateFuturePaymentDate(sampleDate);

			Assert.AreEqual(futureDate.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");


		}
	}
	public struct UnitTestInfo {
		public bool DidTestPass { get; set; }
		public string TestFailureMessage { get; set; }
		public string MethodName { get; set; }

	}
}
