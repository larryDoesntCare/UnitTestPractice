using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLib {
public	class TestThePaymentDate {

		public TestResult DateIs30DaysInFuture() {
			var testResult = new TestResult();

			var pd = new BrokerageLib.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/6/2011"); // will result in a weekday

			var resultWhichShouldBe30DaysLater = pd.CalculateFuturePaymentDate(sampleDate);

			if (resultWhichShouldBe30DaysLater == sampleDate.AddDays(30))
			{
				testResult.TestPassed = true;
			}
			else {
				testResult.TestPassed = false;
				testResult.TestFailedMessage = "Expected date is not 30 days in the future.";
				testResult.MethodName = "DateIs30DaysInFuture";

			}
			testResult.MethodName = "DateIs30DaysInFuture";

			return testResult;
		}

		public TestResult ReturnsMondayIfProposedDateIsSunday() {
			var testResult = new TestResult();
			var pd = new BrokerageLib.PaymentSystem.PaymentDate();

			DateTime sampleDate = DateTime.Parse("7/8/2011");

			var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);


			if (resultDateWhichShouldBeMonday.DayOfWeek == DayOfWeek.Monday)
			{
				testResult.TestPassed = true;
			}
			else {
				testResult.TestPassed = false;
				testResult.TestFailedMessage = "Expected date is not Monday.";

			}
			testResult.MethodName = "ReturnsMondayIfProposedDateIsSunday";

			return testResult;
		}

		public TestResult ReturnsMondayIfProposedDateIsSaturday() {
			var testResult = new TestResult();
			var pd = new BrokerageLib.PaymentSystem.PaymentDate();

			DateTime sampleDate = DateTime.Parse("7/7/2011");

			var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);


			if (resultDateWhichShouldBeMonday.DayOfWeek == DayOfWeek.Monday)
			{
				testResult.TestPassed = true;
			}
			else {
				testResult.TestPassed = false;
				testResult.TestFailedMessage = "Expected date is not Monday.";
			}
			testResult.MethodName = "ReturnsMondayIfProposedDateIsSaturday";

			return testResult;
		}
	}

	public struct TestResult {

		public bool TestPassed { get; set; }
		public string TestFailedMessage { get; set; }
		public string MethodName { get; set; }
	}
}
