using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SUT = BrokerageLib;

namespace BrokerageLib.xUnit {
	public class GettingAPaymentDate_Should {
		[Fact]
		public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday() {
			// Long names are nice for explaining the purpose 
			// of the test

			// Unfortunately, Test Explorer always shows the  
			// fully qualified name 
		}

		[Fact]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {
			// no code needed for this demo
		}

		[Fact]
		public void ReturnMonday_WhenProposedDateFallsOnSaturday() {
			// no code needed for this demo
		}
	}
}
