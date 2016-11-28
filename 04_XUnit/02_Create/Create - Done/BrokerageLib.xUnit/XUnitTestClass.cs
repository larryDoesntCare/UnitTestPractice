using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class XUnitTestClass {
		[Fact]
		public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday() {
			// arrange
			var pd = new SUT.PaymentSystem.PaymentDate();
			DateTime sampleDate = DateTime.Parse("7/6/2011");
			// act
			var futureDate = pd.CalculateFuturePaymentDate(sampleDate);
			// assert

			Assert.Equal(sampleDate.AddDays(30), futureDate);
			// Assert.AreEqual(sampleDate.AddDays(30), futureDate);
		}
	}
}
