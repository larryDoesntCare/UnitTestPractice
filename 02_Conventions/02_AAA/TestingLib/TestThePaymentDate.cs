using System;

namespace TestingLib {

	public class TestThePaymentDate {

		[CheckThisMethod]
		public void DateIs30DaysInFuture() {
			var pd = new BrokerageLib.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/6/2011"); // will result in a weekday

			var resultWhichShouldBe30DaysLater = pd.CalculateFuturePaymentDate(sampleDate);

			Assert.AreEqual(resultWhichShouldBe30DaysLater, sampleDate.AddDays(30), "Expected date is not 30 days in the future.");
		}

		[CheckThisMethod]
		public void ReturnsMondayIfProposedDateIsSunday() {
			var pd = new BrokerageLib.PaymentSystem.PaymentDate();

			DateTime sampleDate = DateTime.Parse("7/8/2011");

			var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

			Assert.AreEqual(resultDateWhichShouldBeMonday.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");
		}

		[CheckThisMethod]
		public void ReturnsMondayIfProposedDateIsSaturday() {
			var pd = new BrokerageLib.PaymentSystem.PaymentDate();

			DateTime sampleDate = DateTime.Parse("7/7/2011");

			var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);
			Assert.AreEqual(resultDateWhichShouldBeMonday.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");
		}
	}

	public struct TestResult {
		public bool TestPassed { get; set; }
		public string TestFailedMessage { get; set; }
		public string MethodName { get; set; }
		public string ClassName { get; set; }
	}
}