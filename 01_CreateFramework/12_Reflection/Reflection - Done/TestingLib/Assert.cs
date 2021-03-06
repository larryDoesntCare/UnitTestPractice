﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System;
using System.Linq;


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
		public static void RunTests() {
			foreach (MethodInfo method in GetTestMethods())
			{
				var instanceOfTestClass = Activator.CreateInstance(method.DeclaringType);
				method.Invoke(instanceOfTestClass, null);
			}
		}

		private static List<MethodInfo> GetTestMethods() {
			var q = from t in Assembly.GetExecutingAssembly().GetTypes()
							from m in t.GetMethods()
							from att in m.GetCustomAttributes(true)
							where att.GetType() == typeof(CheckThisMethod)

							select m;

			return q.ToList();
		}

		}
}