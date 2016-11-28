﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestingLib {
	public static class Assert {
		public static ObservableCollection<UnitTestInfo> TestResults { get; set; }

		static Assert() {
			TestResults = new ObservableCollection<UnitTestInfo>();
		}
		public static void AreEqual(object first,
																object second,
																string message,
																[CallerMemberName] string methodName = null) {

			var testInfo = new UnitTestInfo();
			if (first.Equals(second))
			{
				testInfo.DidTestPass = true;
			}
			else {
				testInfo.DidTestPass = false;
				testInfo.TestFailureMessage = message;
			}
			testInfo.MethodName = methodName;

			TestResults.Add(testInfo);
		}
	}
}
