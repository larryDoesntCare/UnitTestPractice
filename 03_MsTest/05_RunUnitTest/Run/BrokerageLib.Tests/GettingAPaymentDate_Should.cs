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
		}

		[TestMethod]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {	}

		[TestMethod]
		public void ReturnMonday_WhenProposedDateFallsOnSaturday() {	}
			
		
	}
}
