using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CategoriesAndTraits.MsTest {
	[TestClass]
	public class CategoryExample {
		[TestMethod]
		public void InitializeAccount_WhenCustomerInformationIsSupplied() {
		}

		[TestMethod]

		public void InitializeAccount_WhenAccountIsNew() {

		}

		[TestMethod]

		public void ListConnectionsAvailable_WhenNetworkAvailable() {
			Thread.Sleep(500);
		}

		[TestMethod]
		public void ConnectToDefaultSource_WhenNetworkAvailable() {
		}

		[TestMethod]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {
		}

		[TestMethod]

		public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold() {
			Assert.IsTrue(4 == 5);
		}

		[TestMethod]

		public void ThrowArgumentOutOfRangeException_WhenNegativePrice() {
		}

		[TestMethod]

		public void ThrowArgumentNullReferencException_MissingFinancialData() {
		}
	}
}
