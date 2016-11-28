using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT = BrokerageLib;

namespace BrokerageLib.Tests {
	[TestClass]
	public class GettingAPaymentDate_Should {
		[TestMethod]
		public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday() {
			Assert.Fail();
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
