using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUT = BrokerageLib;

namespace BrokerageLib.nUnit {
	[TestFixture]
	class NUnitParams {



		[TestCase]
		public void ReturnTrue_WhenThereIsAOddDigit(int candidateNumber) {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(candidateNumber);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}
		[TestCase]
		public void ReturnsCount_Theory(int candidateNumber,
																		 int testDigit,
																		 int expectedCount) {
			// arrange

			var analyzer = new SUT.NumberAnalyzer(candidateNumber);

			// act

			var result = analyzer.GetTheCountOfThisDigit(testDigit);

			// assert

			Assert.AreEqual(expectedCount, result);

		}

	}
}
