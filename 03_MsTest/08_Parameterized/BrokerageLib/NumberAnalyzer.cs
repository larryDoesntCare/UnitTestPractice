using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerageLib {
	public class NumberAnalyzer {
		private int _candidateNumber;
		public NumberAnalyzer(int candidateNumber) {
			_candidateNumber = candidateNumber;
		}
		public bool ContainsOddDigit() {
			int temp;
			var candidateString = _candidateNumber.ToString();

			foreach (char theChar in candidateString)
			{

				temp = (int)theChar;
				if (temp %2 ==1 )
				{
					return true;
				}
			}
			return false;
		}

		static string FormatDigits(int value) {
			return value < 10
							? value.ToString()
							: FormatDigits(value / 10) + " " + FormatDigits(value % 10);
		}

	}
}
