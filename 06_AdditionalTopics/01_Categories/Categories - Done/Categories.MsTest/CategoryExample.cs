using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CategoriesAndTraits.MsTest {

	[TestClass]
	public class CategoryExample {

		[TestMethod]
		[TestCategory("Constructor")]
		public void InitializeAccount_WhenCustomerInformationIsSupplied() {
		}

		[TestMethod]
		[TestCategory("Constructor")]
		public void InitializeAccount_WhenAccountIsNew() {
		}

		[TestMethod]
		[TestCategory("Sprint 14")]
		public void ReturnMonday_WhenProposedDateFallsOnSunday() {
		}

		[TestMethod]
		[TestCategory("Exceptions")]
		public void ThrowArgumentOutOfRangeException_WhenNegativePrice() {
		}

		[TestMethod]
		[TestCategory("Exceptions"), TestCategory("Sprint 14")]
		public void ThrowArgumentOutOfRangeException_WhenNegativeUnitsSold() {
		}

		[TestMethod]
		[TestCategory("Exceptions"), TestCategory("Sprint 14")]
		public void ThrowArgumentNullReferencException_MissingFinancialData() {
		}

		[TestMethod]
		public void VerifyConnectionsAvailable_WhenNetworkAvailable() {
		}
	}
}