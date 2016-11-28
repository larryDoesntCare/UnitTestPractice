using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerageLib.Tests {
	[TestClass]
	public class GettingAPaymentDate_Should {
		[TestMethod]
		public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday() {
			Assert.Fail();
		}

		[TestMethod]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {

			Assert.Fail();
		}

		[TestMethod]
		public void ReturnMonday_WhenProposedDateFallsOnSaturday() {
			Assert.Fail();
		}
		}
}
