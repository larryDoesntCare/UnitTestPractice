using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerageLib.Tests {
	[TestClass]
	public class CheckingForOddDigit_Should {

		[TestMethod]
		public void ReturnTrue_WhenThereIsAOne() {
			// arrange

			var analyzer = new BrokerageLib.NumberAnalyzer(2210);

			// act

			var result = analyzer.ContainsOddDigit();

			// assert

			Assert.IsTrue(result);

		}

		[TestMethod]
		public void ReturnTrue_WhenThereIsAThree() {
			// arrange

			var analyzer = new BrokerageLib.NumberAnalyzer(44203);

			// act

			var result = analyzer.ContainsOddDigit();

			// assert

			Assert.IsTrue(result);

		}

		[TestMethod]
		public void ReturnTrue_WhenThereIsAnOddDigit() {
			// arrange

			var analyzer1 = new BrokerageLib.NumberAnalyzer(2210);
			var analyzer3 = new BrokerageLib.NumberAnalyzer(4432);
			var analyzer5 = new BrokerageLib.NumberAnalyzer(5002);
			var analyzer7 = new BrokerageLib.NumberAnalyzer(8766);
			var analyzer9 = new BrokerageLib.NumberAnalyzer(9000);
	
			// act and assert

			Assert.IsTrue(analyzer1.ContainsOddDigit());
			Assert.IsTrue(analyzer3.ContainsOddDigit());
			Assert.IsTrue(analyzer5.ContainsOddDigit());
			Assert.IsTrue(analyzer7.ContainsOddDigit());
			Assert.IsTrue(analyzer9.ContainsOddDigit());

		}

		//[DataTestMethod]
		//[DataRow(2210)]
		//[DataRow(4432)]
		//[DataRow(5002)]
		//[DataRow(8766)]
		//[DataRow(9000)]
		//[DataRow(113579)]
		//public void ReturnTrue_WhenThereIsAOddDigit(int candidate) {
		//	// arrange

		//	var analyzer = new BrokerageLib.NumberAnalyzer(candidate);

		//	// act

		//	var result = analyzer.ContainsOddDigit();

		//	// assert

		//	Assert.IsTrue(result);

		//}


	}
}
