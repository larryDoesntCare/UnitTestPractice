using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CategoriesAndTraits.MsTest {
	[TestClass]
	public class CategoryExample {
		[TestMethod]
		[Ignore]
		[TestCategory("Demo")]
		public void InitializeAccount_WhenCustomerInformationIsSupplied() {
		}

		[TestMethod]
		[Ignore]
		[TestCategory("Constructor")]
	
		public void InitializeAccount_WhenAccountIsNew() {
			
		}

		[TestMethod]
		[Owner("Walt Ritscher")]
		[TestCategory ("Network")]
		[TestProperty("Slow", "May take 10 minutes to run this test.")]
		public void ListConnectionsAvailable_WhenNetworkAvailable() {
			Thread.Sleep(500);
		}

		[TestMethod]
		[Owner("Tadd Pouhl")]
		[TestCategory("Network")]
			public void ConnectToDefaultSource_WhenNetworkAvailable() {
		}

		[TestMethod]
		[TestCategory("Sprint 14")]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {
		}

		[TestMethod] 
		[TestCategory("Exceptions"), TestCategory("Sprint 14")]
		public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold()  {
			Assert.IsTrue(4 == 5);
		}

		[TestMethod]
		[TestCategory("Exceptions")]
		public void ThrowArgumentOutOfRangeException_WhenNegativePrice() {
		}

		[TestMethod]
		[TestCategory("Exceptions"), TestCategory("Sprint 14")]
		public void ThrowArgumentNullReferencException_MissingFinancialData() {
		}
	}
}
