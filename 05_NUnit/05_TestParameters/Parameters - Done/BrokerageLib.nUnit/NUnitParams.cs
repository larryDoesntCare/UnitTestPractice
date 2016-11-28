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



		[TestCase(2201)]
		[TestCase(603)]
		[TestCase(700)]
		public void ReturnTrue_WhenThereIsAOddDigit(int candidateNumber) {
			// arrange
			var analyzer = new SUT.NumberAnalyzer(candidateNumber);

			// act
			var result = analyzer.ContainsOddDigit();

			// assert
			Assert.True(result);

		}

		[TestCase(101, 1, 2)]
		[TestCase(222345, 2, 3)]
		[TestCase(123, 4, 0)]
		public void ReturnsCountWithMultiParam(int candidateNumber,
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
